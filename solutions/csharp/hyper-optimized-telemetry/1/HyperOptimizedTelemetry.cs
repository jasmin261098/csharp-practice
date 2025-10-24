using System;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        int numBytes;
        bool isSigned;
        
        if (reading >= 0 && reading <= 65535) {
            numBytes = 2;
            isSigned = false; // ushort
        } else if (reading >= -32768 && reading <= -1) {
            numBytes = 2;
            isSigned = true; // short
        } else if (reading >= -2_147_483_648 && reading <= 2_147_483_647) {
            numBytes = 4;
            isSigned = true; // int
        } else if (reading >= 2_147_483_648 && reading <= 4_294_967_295) {
            numBytes = 4;
            isSigned = false; // uint
        } else {
            numBytes = 8;
            isSigned = true; // long
        }

        byte prefix = isSigned ? (byte)(256 - numBytes) : (byte)numBytes;

        byte[] buffer = new byte[9];
        buffer[0] = prefix;

        byte[] payload = BitConverter.GetBytes(reading); // converts long to bytes
        Array.Copy(payload, 0, buffer, 1, numBytes);

        return buffer;
    }

    public static long FromBuffer(byte[] buffer)
    {
        if (buffer == null || buffer.Length != 9)
            return 0;

        byte prefix = buffer[0];
        bool isSigned = prefix >= 128;
        int numBytes = isSigned ? 256 - prefix : prefix;

        // Validate number of bytes and buffer length
        if (numBytes < 1 || numBytes > 8 || buffer.Length < 1 + numBytes)
            return 0;

        byte[] payload = new byte[8]; // always 8 bytes for conversion
        Array.Copy(buffer, 1, payload, 0, numBytes);

        long value;

        if (isSigned) {
            switch(numBytes) {
                case 2: value = BitConverter.ToInt16(payload, 0); break;
                case 4: value = BitConverter.ToInt32(payload, 0); break;
                case 8: value = BitConverter.ToInt64(payload, 0); break;
                default: return 0; // should never reach here
            }
        } else {
            switch(numBytes) {
                case 2: value = BitConverter.ToUInt16(payload, 0); break;
                case 4: value = BitConverter.ToUInt32(payload, 0); break;
                case 8: value = (long)BitConverter.ToUInt64(payload, 0); break;
                default: return 0; // should never reach here
            }
        }

        return value;
    }
}
