#!/usr/bin/env python
# coding: utf-8

# # Computing 6 Assignment
# 
# 

# ---
# ## Background
# 
# In this assignment you will be implementing a portion of a Geographic Information System (GIS). A GIS is a computer system used to organize, categorize, and analyze geographical data in order to produce accurate depiction of the real world. The system uses multiple layers of information to achieve this task. The data layers are split into a grid and represented as a matrix with **m** rows and **n** columns where each entry in the matrix contains the type of land at that point on the map. An entry **A<sub>ij</sub>** is the *i*th row and *j*th column in our map matrix. We assume that **A<sub>00</sub>** is the first element in our matrix. The graphic below will assist in visualizing the process:
# 
# ![Comp6.png](attachment:Comp6.png)
# \begin{align}
#   \texttt{Figure 1}
# \end{align}
# 
# 
# As seen in the previous example, our GIS utilizes **6** different data layers. We call these layers the **map types** as they classify regions of different land on our map. Thus, each entry in our map matrix can be **one** of the 6 map types.
# 
# -	Transportation (T)
# -	Agricultural (A)
# -	Residential (R)
# -	Commercial (C)
# -	Water (W)
# -	Undeveloped land (U)
# 
# Our GIS will store the map information as a list of lists. If we have a list named **map**, then map[i][j] will store the map type at row i, column j. Each entry will contain a string that corresponds to 1 of the 6 possible map types listed above. The list representation of the map in **Figure 1** is shown below:
# 
# 
# ```
# [['A','A','A','A','U','U','U','U'],    
#  ['A','A','A','A','U','R','R','R'],    
#  ['W','W','W','W','T','T','T','T'],    
#  ['W','W','W','W','T','R','R','R'],
#  ['C','C','U','U','T','R','U','U'],    
#  ['T','T','T','T','T','T','U','U'],    
#  ['U','U','U','U','T','R','U','U']]
# ```
# 
# One usage of the system is to be able to easily identify whether or not a piece of land (entry in the map matrix) is deemed **commercially buildable**. A piece of land at **A<sub>ij</sub>** is deemed commercially buildable if the following conditions hold:
# -	The entry at **A<sub>ij</sub>** has map type **U**
# -	The entry **A<sub>ij</sub>** is not on the edges of the map (the first and last rows and columns).
# -	The entry **A<sub>ij</sub>** is not adjacent with an entry of map type **R** or map type **A**. Note that adjacent entries are entries to the top, bottom, left, and right of the current cell.
# 
# Based on the criteria and the map representation of **Figure 1**, it can be seen that **A<sub>4,2</sub>** is commercially buildable and **A<sub>1,4</sub>** is not commercially buildable. 
# 
# Please read the requirements below to implement the GIS system!
# 

# ---
# ## Additional Information
# When using a 2D list, we can access elements around a specific index. Given the element at location i,j we can find the adjacent element within the same row by changing the row index. If we want to access the element to the *left* of our selected element, we can subtract 1 from the j index. To access the element to the right, we can add 1 to the j index. To access the element in the previous row (above the element), we can subtract 1 from the i index. To access the element in the next row (below the element), we can add 1 to the i index.

# In[ ]:


x = [[1,2,3],
     [4,5,6], 
     [7,8,9]]
i=1
j=1
print(x[i][j])
print(x[i-1][j]) # above
print(x[i][j+1]) # right


# Be careful when accessing adjacent elements - if you try to access an element that doesn't exist, you might receive unexpected output, or an error!

# In[ ]:


print(x[i-2][j]) # 2 above - actually wraps around and gives us the element in row -1 (which is the last row)
print(x[i][j+2]) # 2 right - tries to access value in column 3 (which doesn't exist)


# ---
# ## NOTE THAT YOU WILL BE MARKED ON MULTIPLE ITEMS IN THIS LAB IN ADDITION TO THE FUNCTIONALITY OF YOUR CODE
#  - Variable Names
#  - Commenting
#  - General Legibility
#  - Reflective Questions

# ---
# ## Program Requirements (12 Marks)
# 
# Your GIS system will be comprised of a set of functions used to analyze the information of any given map. In addition, you will be creating a function used to determine whether or not a piece of land is commercially buildable. The requirements of the system are given below. Please ensure that your functions have the EXACT naming as specified! Failure to do so will result in lost marks.
# 
# 1. Define a function **countType**(*map_data*, *map_type*):
#   - ***map_data***: A *list of lists* representing the data for a given map.
#   - ***map_type***: A *string* representing a map type ('T','A','R','C','W', or 'U')
#   - **Return:** An *integer* representing the number of times *map_type* occurs in *map_data*.
#   
#   
# 2.	Define a function **classifyMap**(*map_data*):
#   -	***map_data***: A *list of lists* representing the data for a given map.
#   -	**Return**: A map classification according to the following rules:
#           -	The *string* **Suburban** if the number of 'R' cells is greater than 50% of all cells.
#           - The *string* **Farmland** if the number of 'A' cells is greater than 50% of all cells.
#           - The *string* **Conservation** if the number of 'U' cells plus the number of 'W' cells is greater than 50% of all cells.
#           - The *string* **City** if the number of 'C' cells is greater than 50% of all cells and the number of 'U' cells plus the number of 'A' cells is between 10% and 20% of all cells (inclusive).
#           - The *string* **Mixed** if none of the above criteria are met.  
#           _(Hint, use your countType function coupled with the fact that the total cells in map\_data is given by m*n)_
#           
# 
# 3.	Define a function **isolateType**(*map_data*, *map_type*):
#   -	***map_data***: A *list of lists* representing the data for a given map.
#   -	***map_type***: A *string* representing a map type (‘T’, ‘A’, ‘R’, ‘C’, ‘W’, or ‘U’)
#   -	**Return**: A new *list of lists* that represent *map_data* as a matrix but all entries that **are not** equal to *map_type* are replaced with a string containing only a space (" ").  
#   
# 
# 4.	Define a function **commerciallyBuildable**(*map_data*, *i*, *j*):
#   -	***map_data***: A *list of lists* representing the data for a given map.
#   -	***i***: An *integer* representing a given row in *map_data*.
#   -	***j***: An *integer* representing a given row in *map_data*.
#   -	**Return**: **True** if *map_data[i][j]* is commercially buildable, otherwise **False**. (Refer to the background section to determine what is deemed commercially buildable)

# ---
# ## Implementation
# Please define all functions in the cell below

# In[36]:


# YOUR CODE HERE
def countType(map_data, map_type):
    '''Returns the amount of occurences of map_type in map_data'''

    if type(map_data) != list:
        raise TypeError

    # loop through list and each sublist and count every occurence
    count = 0
    for row in map_data:
        if type(row) != list:
            raise TypeError

        for entry in row:
            if entry == map_type:
                count += 1

    return count

def classifyMap(map_data):
    '''Returns a string based on the type of development in map_data'''

    # init varibles
    total_cells = len(map_data)*len(map_data[0])
    half_total_cells = 0.5 * total_cells
    land_type_totals = {}  # use a dict to store the amount of tiles for each tile type

    for i in ['T','A','R','C','W','U']:
        land_type_totals[i] = countType(map_data, i)

    # used in the last elif
    undeveloped_farmland_total = land_type_totals['U'] + land_type_totals['A']

    # check the types and return based on params defined in the question
    if land_type_totals['R'] > half_total_cells:
        return 'Suburban'
    elif land_type_totals['A'] > half_total_cells:
        return 'Farmland'
    elif (land_type_totals['U'] + land_type_totals['W']) > half_total_cells:
        return 'Conservation'
    elif (land_type_totals['C'] > half_total_cells and undeveloped_farmland_total <= 0.2*total_cells and          undeveloped_farmland_total >= 0.1 * total_cells):
        return 'City'
    else:
        return "Mixed"

def isolateType(map_data, map_type):
    '''Returns map_data with only occurences of map_type'''

    modified_map = []

    # loop through every row, replace all entries that aren't map_type with " "
    for row in map_data:

        modified_row = []

        for entry in row:
            modified_row.append(entry if entry == map_type else " ")

        modified_map.append(modified_row)

    return modified_map
    
def commerciallyBuildable(map_data, i, j):
    '''Returns True if the specified space is commercially buildable, false otherwise. The conditions for buildable are defined in the question'''
    # make sure land is undeveloped
    buildable = map_data[i][j] == 'U'

    # check if land is on an edge of the map
    buildable = buildable and i != 0 and i != len(map_data) - 1
    buildable = buildable and j != 0 and j != len(map_data[0]) - 1

    # check boxes to the left, right, up and down of the entry, make sure they're of an allowed type
    for k in [i-1, i+1]:
        buildable = buildable and map_data[k][j] not in {'R','A'}

    for k in [j-1, j+1]:
        buildable = buildable and map_data[i][k] not in {'R','A'}

    return buildable


# ---
# ## Sample Output
# Unlike the other computing labs that required you to run main() to validate your code, these functions can act as stand-alone functions. You have been provided with some test cases, but you are encouraged to create more to thoroughly test your code.

# In[1]:


'''MAP = [['A','A','A','A','U','U','U','U'],
       ['A','A','A','A','U','R','R','R'],
       ['W','W','W','W','T','T','T','T'],
       ['W','W','W','W','T','R','R','R'],
       ['C','C','U','U','T','R','U','U'],
       ['T','T','T','T','T','T','U','U'],
       ['U','U','U','U','T','R','U','U']]

MAP2 = [['C','C','C','C','R','T','C'],
        ['T','T','T','T','T','C','C'],
        ['C','C','W','C','R','T','C'],
        ['C','C','C','W','U','T','C'],
        ['C','C','C','U','U','T','C'],
        ['C','C','C','C','C','U','C'],
        ['C','C','C','T','U','U','C'],
        ['C','T','C','T','U','A','C']]


# countType() and classifyMap() functions
print("The number of U spaces in MAP =",countType(MAP, 'U'))
print("The number of T spaces in MAP2 =",countType(MAP2, 'T'))
print("MAP Type =",classifyMap(MAP))
print("MAP2 Type =",classifyMap(MAP2))

# isolateType() function
print("-----------------")
print("Isolated MAP: U")
MA = isolateType(MAP,'U')
for row in MA:
   print(row)
print("-----------------")
print("Isolated MAP2: T")
MB = isolateType(MAP2,'T')
for row in MB:
   print(row)
print("-----------------")

# commerciallyBuildable() function
print("Is MAP commercially buildable at (4,2):",commerciallyBuildable(MAP,4,2))
print("Is MAP2 commercially buildable at (2,2):",commerciallyBuildable(MAP2,2,2))'''

def test1():
   print(countType([['A', 'T', 'C', 'T', 'A'], ['W', 'W', 'T', 'T', 'A'], ['T', 'W', 'W', 'A', 'U'], ['T', 'W', 'R', 'C', 'A'], ['C', 'A', 'U', 'U', 'C']], 'W'))

def test2():
   print(countType([['W', 'W', 'W'], ['W', 'W', 'W'], ['W', 'W', 'W']], 'W'))

def test3():
   print(countType([['W', 'W', 'W'], ['W', 'W', 'W'], ['W', 'W', 'W']], 'C'))

def test4():
   print(countType("Not an array lol", 'W'))

def test5():
   print(classifyMap([['W', 'W', 'W'], 
                   ['W', 'W', 'W'], 
                   ['W', 'W', 'W']]))

def test6():
   mp = [['A','A','A','A','U','U','U','U'],
       ['A','A','A','A','U','R','R','R'],
       ['W','W','W','W','T','T','T','T'],
       ['W','W','W','W','T','R','R','R'],
       ['C','C','U','U','T','R','U','U'],
       ['T','T','T','T','T','T','U','U'],
       ['U','U','U','U','T','R','U','U']]

   print(classifyMap(mp))

def test7():
   print(classifyMap(True))

def test8():
   print(classifyMap([['R', 'R', 'R'],
                   ['R', 'C', 'W'],
                   ['W', 'W', 'W']]))

def test9():
   print(isolateType([['A', 'T', 'C', 'T', 'A'], ['W', 'W', 'T', 'T', 'A'], ['T', 'W', 'W', 'A', 'U'], ['T', 'W', 'R', 'C', 'A'], ['C', 'A', 'U', 'U', 'C']], 'W'))

def test10():
   print(isolateType([['W', 'W', 'W'], ['W', 'W', 'W'], ['W', 'W', 'W']], 'C'))

def test11():
   print(isolateType(None, "W"))

def test12():
   print(commerciallyBuildable([['A','A','A','A','U','U','U','U'],    
                   ['A','A','A','A','U','R','R','R'],    
                   ['W','W','W','W','T','T','T','T'],    
                   ['W','W','W','W','T','R','R','R'],
                   ['C','C','U','U','T','R','U','U'],    
                   ['T','T','T','T','T','T','U','U'],    
                   ['U','U','U','U','T','R','U','U']], 4, 2))

def test13():
   print(commerciallyBuildable([['A','A','A','A','U','U','U','U'],    
                   ['A','A','A','A','U','R','R','R'],    
                   ['W','W','W','W','T','T','T','T'],    
                   ['W','W','W','W','T','R','R','R'],
                   ['C','C','U','U','T','R','U','U'],    
                   ['T','T','T','T','T','T','U','U'],    
                   ['U','U','U','U','T','R','U','U']], 1, 4))

def test14():
   print(commerciallyBuildable("The TA is marking this in the future. They know if $GME is gonna go to the moon or not. I, however, in the present, do not. So, hopefully $GME goes to the moon 🚀🚀🌕", 1, 1))

#test14()


# The expected output for the provided test cases is given below:
# ```
# The number of U spaces in MAP = 17  
# The number of T spaces in MAP2 = 12 
# MAP Type = Mixed 
# MAP2 Type = City  
# -----------------
# Isolated MAP: U
# [' ', ' ', ' ', ' ', 'U', 'U', 'U', 'U']
# [' ', ' ', ' ', ' ', 'U', ' ', ' ', ' ']
# [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ']
# [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ']
# [' ', ' ', 'U', 'U', ' ', ' ', 'U', 'U']
# [' ', ' ', ' ', ' ', ' ', ' ', 'U', 'U']
# ['U', 'U', 'U', 'U', ' ', ' ', 'U', 'U']
# -----------------
# Isolated MAP2: T
# [' ', ' ', ' ', ' ', ' ', 'T', ' ']
# ['T', 'T', 'T', 'T', 'T', ' ', ' ']
# [' ', ' ', ' ', ' ', ' ', 'T', ' ']
# [' ', ' ', ' ', ' ', ' ', 'T', ' ']
# [' ', ' ', ' ', ' ', ' ', 'T', ' ']
# [' ', ' ', ' ', ' ', ' ', ' ', ' ']
# [' ', ' ', ' ', 'T', ' ', ' ', ' ']
# [' ', 'T', ' ', 'T', ' ', ' ', ' ']
# -----------------
# Is MAP commercially buildable at (4,2): True  
# Is MAP2 commercially buildable at (2,2): False
# ```

# ----------
# ## Code Legibility (6 Marks)
# Your code will be marked on commenting and code legibility.<br>
# The mark breakdown is as follows:<br>
# > 2 marks for using appropriate variable names that indicate what is being stored in that variable<br>
# 2 marks for leaving comments on major parts of your code such as where you read the file or calculate a summation<br>
# 2 marks for general legibility. The TA's should be able to understand your code without spending hours reading it. For example do not put your code in one very long line as this is hard for someone else reading your code to understand

# ---
# ## Test Plan
# Develop a test plan for your program. Your test plan should have at least three test cases: one normal case, one boundary case, and one abnormal case. You can test any function but you must test **at least two different** functions. Please use the following format for your test cases:
# 
# **Function:**   
# **Input:**  
# **Output:**  
# **Excepted Output:**  
# **Pass/Fail:**  
# 
# An example test case is shown below:  
# ```
# Function: countType(map_data,map_type)
# Input: map_data = [['U','T','U','A'],
#                     ['R','T','W','A'],
#                     ['U','T','A','W']]  
#        map_type = 'U'
# Output: 3
# Excpected Output: 3
# Pass/Fail: Pass
# ```
# 
# Implement your testing plan in the cell below! 

# ```
# DOUBLE CLICK TO EDIT THIS CELL. DO NOT DELETE QUOTATION MARKS
# 
# Function: countType
# Input: map_data = [['A', 'T', 'C', 'T', 'A'], 
#                    ['W', 'W', 'T', 'T', 'A'], 
#                    ['T', 'W', 'W', 'A', 'U'], 
#                    ['T', 'W', 'R', 'C', 'A'], 
#                    ['C', 'A', 'U', 'U', 'C']]
# 
#         map_type = 'W'
# Output: 5
# Excepted Output: 5
# Pass/Fail: Pass
# 
# Function: countType
# Input: map_data = [['W', 'W', 'W'], 
#                    ['W', 'W', 'W'], 
#                    ['W', 'W', 'W']]
#        map_type = 'W'
# Output: 9
# Excepted Output: 9
# Pass/Fail: Pass
# 
# Function: countType
# Input: map_data = [['W', 'W', 'W'], 
#                    ['W', 'W', 'W'], 
#                    ['W', 'W', 'W']]
#        map_type = 'C'
# Output: 0
# Excepted Output: 0
# Pass/Fail: Pass
# 
# Function: countType
# Input: map_data = "Not an array lol"
#        map_type = 'W'
# Output: 0
# Excepted Output: Some type of error
# Pass/Fail: Fail
# Note: because of the way python handles indexing strings, attempting to loop through a string with length of 1 (as would happen in this function)
# just does the operation on the one character of the string. I can throw a TypeError to deal with this
# 
# Function: countType
# Input: map_data = "Not an array lol"
#        map_type = 'W'
# Output: TypeError
# Excepted Output: TypeError
# Pass/Fail: Pass
# 
# Function: classifyMap
# Input: map_data = [['W', 'W', 'W'], 
#                    ['W', 'W', 'W'], 
#                    ['W', 'W', 'W']]
# Output: Conservation
# Excepted Output: Conservation
# Pass/Fail: Pass
# 
# Function:classifyMap
# Input: map_data = [['A','A','A','A','U','U','U','U'],
#                    ['A','A','A','A','U','R','R','R'],
#                    ['W','W','W','W','T','T','T','T'],
#                    ['W','W','W','W','T','R','R','R'],
#                    ['C','C','U','U','T','R','U','U'],
#                    ['T','T','T','T','T','T','U','U'],
#                    ['U','U','U','U','T','R','U','U']]
# Output: Mixed
# Excepted Output: Mixed
# Pass/Fail: Pass
# 
# Function: classifyMap
# Input: map_data=True
# Output: TypeError
# Excepted Output: TypeError
# Pass/Fail: Pass
# 
# Function: classifyMap
# Input: map_data = [['R', 'R', 'R'],
#                    ['R', 'C', 'W'],
#                    ['W', 'W', 'W']]
# Output: Mixed
# Excepted Output: Mixed
# Pass/Fail: Pass
# 
# Function: isolateType
# Input: map_data = [['A', 'T', 'C', 'T', 'A'],
#                    ['W', 'W', 'T', 'T', 'A'],
#                    ['T', 'W', 'W', 'A', 'U'],
#                    ['T', 'W', 'R', 'C', 'A'],
#                    ['C', 'A', 'U', 'U', 'C']]
#        map_type = 'W'
# Output: [[' ', ' ', ' ', ' ', ' '], ['W', 'W', ' ', ' ', ' '], [' ', 'W', 'W', ' ', ' '], [' ', 'W', ' ', ' ', ' '], [' ', ' ', ' ', ' ', ' ']]
# Excepted Output: [[' ',' ',' ',' ',' ']
#                   ['W','W',' ',' ',' ']
#                   [' ','W','W',' ',' ']
#                   [' ','W',' ',' ',' ']
#                   [' ',' ',' ',' ',' ']]
# Pass/Fail: Pass
# 
# Function: isolateType
# Input: map_data = [['W', 'W', 'W'], 
#                    ['W', 'W', 'W'], 
#                    ['W', 'W', 'W']]
#        map_type = 'C'
# Output: [[' ', ' ', ' '], [' ', ' ', ' '], [' ', ' ', ' ']]
# Excepted Output: empty 3*3 array
# Pass/Fail: Pass
# 
# Function: isolateType
# Input: map_data = None
#        map_type = 'C'
# Output: TypeError
# Excepted Output: TypeError
# Pass/Fail: Pass
# 
# Function: commerciallyBuildable
# Input: map_data = [['A','A','A','A','U','U','U','U'],    
#                    ['A','A','A','A','U','R','R','R'],    
#                    ['W','W','W','W','T','T','T','T'],    
#                    ['W','W','W','W','T','R','R','R'],
#                    ['C','C','U','U','T','R','U','U'],    
#                    ['T','T','T','T','T','T','U','U'],    
#                    ['U','U','U','U','T','R','U','U']]
#        i=4
#        j=2
# Output: True
# Excepted Output: True
# Pass/Fail: Pass
# 
# Function: commerciallyBuildable
# Input:map_data = [['A','A','A','A','U','U','U','U'],    
#                    ['A','A','A','A','U','R','R','R'],    
#                    ['W','W','W','W','T','T','T','T'],    
#                    ['W','W','W','W','T','R','R','R'],
#                    ['C','C','U','U','T','R','U','U'],    
#                    ['T','T','T','T','T','T','U','U'],    
#                    ['U','U','U','U','T','R','U','U']]
#        i=1
#        j=4
# Output: False
# Excepted Output: False
# Pass/Fail: Pass
# 
# Function: commerciallyBuildable
# Input: map_data = "The TA is marking this in the future. They know if $GME is gonna go to the moon or not. I, however, in the present, do not. So, hopefully $GME goes to the moon 🚀🚀🌕"
#        i = 1
#        j = 1
# Output: IndexError
# Excepted Output: TypeError
# Pass/Fail: Pass
# Note: The IndexError occurs because the program tries to index a 1 length string with an index other than 0. This is fine, as in this abnormal case any error is acceptable.
# ```

# ---
# ## Reflective Questions (6 Marks)
# 
# 1. Which functions did you use a nested structure (nested loops, nested conditionals, etc) to implement the requirements? Would it have been possible to implement them without using a nested structure? Which functions did you *not* use a nested structure? Would it have been possible to implement them *with* a nested structure?  
# 
# 
# 2. Suppose we wanted to create an additional map classification called 'Urban City' which is indicated by the number of 'R' cells plus the number of 'C' cells being between 60% and 80%. Can we do this? How might this affect our classifyMap() function?
# 
# 
# 3. How many test cases would you need to confirm that your classifyMap() function correctly identifies a "Farmland" map? Explain what your test cases would be.

# ```
# DOUBLE CLICK TO EDIT THIS CELL. DO NOT DELETE QUOTATION MARKS
# 
# 1. countType, isolateType, and classifyMap use nested for loops. Besides hardcoding, it is impossible to write countType without a nested for loop (including for loops that are built into other python functions), as it needs to indiviually access every element in the 2D array. The same is true for isolateType. classifyMap uses a for loop in its call to countType. commerciallyBuildable does not use a nested for loop, however, when checking the neighbouring tiles, it is possible to use a nested for loop.
# 
# 2. This is completley possible. One would need to put the if statement for this before the if statement for suburban land type. This is because this new land type also fufils the requirements for suburban land.
# 
# 3. Because the check to identify a farmland map is relativley simple (>50% of cells are agricultural), one would need 5 tests. First, a normal case. Second, 2 boundry cases (with 50% of cells being agricultural and 0% being agricultural). Third, two abnormal tests (One with the input as a non-list data type, another with a non-2D list as input)
# ```

# ---
# ## Submission
# 
# Please download this notebook as a .py file (*File* > *Download as* > *Python (.py)*) and submit it to the Computing Lab 6 dropbox on avenue with the naming convention: macID_CL6.py
# 
# **Make sure the final version of your lab runs without errors, otherwise, you will likely recieve zero.**
# 
# This assignment is due the day after your Lab A section at 11:59 PM EST
# 
# Late labs will not be accepted
