#!/usr/bin/env python3

input="""
8 	1 	6
3 	5 	7
4 	9 	2

	
6 	1 	8
7 	5 	3
2 	9 	4

	
2 	7 	6
9 	5 	1
4 	3 	8

	
4 	3 	8
9 	5 	1
2 	7 	6

2 	9 	4
7 	5 	3
6 	1 	8

	
4 	9 	2
3 	5 	7
8 	1 	6

	
6 	7 	2
1 	5 	9
8 	3 	4

	
8 	3 	4
1 	5 	9
6 	7 	2 
"""

# These are all possible magic squares as copy-pasted from wikipedia.
# This script will turn them into arrays for use in the main program.

input = input.split()

output = list()

for i in range(len(input)):
    input[i] = int(input[i])


print(input)
