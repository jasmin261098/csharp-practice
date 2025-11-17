"""Functions used in preparing Guido's gorgeous lasagna.

Learn about Guido, the creator of the Python language:
https://en.wikipedia.org/wiki/Guido_van_Rossum

This is a module docstring, used to describe the functionality
of a module and its functions and/or classes.
"""

EXPECTED_BAKE_TIME = 40
PREPARATION_TIME = 2

def bake_time_remaining(elapsed_bake_time):
    """bake_time_remaining function that takes the actual minutes the lasagne has been in the oven as an argument und return how many minutes the lasagne still needs to baked."""
    return EXPECTED_BAKE_TIME - elapsed_bake_time

def preparation_time_in_minutes(number_of_layers):
    """preparation_time_in_minutes function that takes the number of layers you want to add to the lasagne as an argument and returns how many minutes you spend making it."""
    return number_of_layers * PREPARATION_TIME

def elapsed_time_in_minutes(number_of_layers, elapsed_bake_time):
    """elapsed_time_in_minutes function takes the number of layer and the elapsed bake time and returns the total preparation time."""
    preparation_time = number_of_layers * PREPARATION_TIME
    return preparation_time + elapsed_bake_time
