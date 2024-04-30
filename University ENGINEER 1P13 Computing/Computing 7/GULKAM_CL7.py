#!/usr/bin/env python
# coding: utf-8

# # Computing 7 Assignment
# 
# 

# ---
# ## Background
# 
# In this assignment, you will be extracting daily temperature data, sorting the data, and then calculating the median temperature for a given set of data.
# 
# A set of daily temperature data will be provided to you as a *list* of strings. For example:
# 
# <br>
# <center><code>temps = ["5","-1.0","1.1","None","9","NA","1.0"]</code></center>
# <br>
# 
# Note that the temperature may not be recorded on some days. A sequence of characters that cannot be represented as a number indicate that the temperature was not recorded on a given day. In the previous example, we can see that the strings "None" and "NA" were used to represent days where the temperature was not recorded. It is important to note that these strings can consist of any characters and can vary in length. Some more examples would be "" (the empty string), "Nothing", "Not recorded", "Forgot", etc.
# 
# To calculate the median temperature for a given set of data, we first need to convert the data to a list of numbers. The data converted from the *temps* list is given below. Notice how the days that did not have a recorded temperature were ignored:
# 
# <br>
# <center><code>temps_extracted=[5.0,-1.0,1.1,9.0,1.0]</code></center>
# <br>
# 
# How would we calculate the median of our list? Recall that the median is a value separating the higher half from the lower half of a list of sorted values. In the case where the length of our list of numbers is odd, the median is the middle element in our list. In the case where the length of our list of numbers is even, the median can be found by taking the average of the two center most elements. 
# 
# We cannot calculate the median until we sort our values. Our sorted temperatures will look as follows:
# 
# 
# <br>
# <center><code>temps_sorted=[-1.0,1.0,1.1,5.0,9.0]</code></center>
# <br>
#   
#     
# Now that our list is sorted, we can see that the median in this case is **1.1**.
# <br>
# 
# ---
#     
# So how do we sort a list of values? Formally, a sorting algorithm is a sequence of steps that are used to sort a sequence of values. It turns out that there exist many different sorting algorithms, some more complicated than others. In todays assignment we are going to focus on an intuitive sorting algorithm known as **selection sort**. We are going to use this algorithm to sort a list of numbers in ascending order.
# <br>
#     
# Say we have a list named *nums*. The main idea of selection sort is that we want to start iterating over our list *nums* from i = 0 to the length of our list minus 1 (n-1), choosing the smallest element in the sub list from *nums[i]* to *nums[n-1]* and placing it in *nums[i]* on each iteration. If you are confused, don't worry! We have provided you the pseudocode for the algorithm. Before looking at the pseudocode, use the following example to gain some intuition about how selection sort works.
# <br>
# <br>
# 
# Imagine that we have the following list of numbers that need to be sorted:
# 
# ![alg%20%2826%29.png](attachment:alg%20%2826%29.png)
# 
# 
# We start sorting at the left most item. We call our current position index i. The left most element in our list is the number 2, which occurs at i = 0.
# 
# ![alg%20%2825%29.png](attachment:alg%20%2825%29.png)
# 
# When considering the final sorted list, should the number 2 be in this position? What is the smallest element in our list from index i to the end of our list (index 4)? By inspection, we can see that the smallest number is 1. We can identify the position of this number using the variable min_index, which in this case is min_index = 2. Therefore the number 1 should be at index i because it is the smallest element in our list from index 0 to index 4!
# 
# ![alg%20%2824%29.png](attachment:alg%20%2824%29.png)
# 
# We can guarantee that the number 1 will be in the correct position in our final sorted list if we swap the elements at i and min_index! 
# 
# ![alg%20%2823%29.png](attachment:alg%20%2823%29.png)
# 
# You might think that 2 is still not in its correct position, but don't worry! We can guarantee that the number 1 is in the correct position, and we will worry about 2 later.
# <br>
# <br>
# 
# Let's now increment i to 1.
# ![alg%20%2821%29.png](attachment:alg%20%2821%29.png)
# 
# Let's perform the same actions we did when i was 0. What is the smallest element in our list from the element at this position (i = 1) to the end of our list (index 4)? By inspection, we can see that the smallest number is 2 which occurs at index 2, thus min_index = 2 in this case.
# 
# ![alg%20%289%29.png](attachment:alg%20%289%29.png)
# 
# We then swap the elements at i and min_index!
# 
# ![alg%20%2811%29.png](attachment:alg%20%2811%29.png)
# 
# Let's now increment i once again to 2.
# 
# ![alg%20%2812%29.png](attachment:alg%20%2812%29.png)
# 
# Can you see what's going on here? All of the elements (green) to the left of our current index i are sorted! Therefore our entire list will be sorted if we continue with this algorithm until we reach the end of our list. The following illustrations demonstrate how the algorithm will perform for the rest of the list.
# 
# ![alg%20%2820%29.png](attachment:alg%20%2820%29.png)
# ![alg%20%2814%29.png](attachment:alg%20%2814%29.png)
# 
# Increment i once again.
# 
# ![alg%20%2815%29.png](attachment:alg%20%2815%29.png)
# ![alg%20%2819%29.png](attachment:alg%20%2819%29.png)
# ![alg%20%2817%29.png](attachment:alg%20%2817%29.png)
# 
# When we increment i one last time, we reach the end of our list and all elements are sorted!
# 
# ![alg%20%2818%29.png](attachment:alg%20%2818%29.png)
# 
# <br>
# 
# The pseudocode for the algorithm is given below. We assume that the list we are sorting is given by the name *nums*.
# ```
# Create a variable n and set it equal to the length of nums
# For i = 0 to n-1
#     Create a variable min_index, and set it equal to i
#     For j=i to n-1
#         if nums[j] is less than nums[min_index] then set min_index to j
#     endFor
#     Swap the elements at nums[i] and nums[min_index]
# endFor
# ```
# 
# It is your task to implement the sorting algorithm from the pseudocode, as well as other functions listed in the requirements section of this document.

# ---
# ## NOTE THAT YOU WILL BE MARKED ON MULTIPLE ITEMS IN THIS LAB IN ADDITION TO THE FUNCTIONALITY OF YOUR CODE
#  - Variable Names
#  - Commenting
#  - General Legibility
#  - Try and Except
#  - Test Plan

# ---
# ## Program Requirements (12 Marks)
# 
# The requirements of the system are given below. Please ensure that your functions have the EXACT naming as specified! Failure to do so will result in lost marks. 
# 
# ***Note: you must include a try and except statement in at least two functions in your code.***
# 
# 1.	Define a function **extract_temps**(*temps*):
#   - ***temps***: A *list* of *strings* representing a set of daily temperatures. 
#   -	**Return**: A *list* of floats that represent the elements in *temps* that could be converted into floats.
#   <br>*Note: Some of the items in temps cannot be represented as a float. These items should be ignored. Refer to the background section as an example*
#   
#  
# 2.	Define a function **selection_sort**(*nums*):
#   -	***nums***: A *list* of floats.
#   -	**Return**: A sorted copy of the list *nums* using the selection sort algorithm.
#       <br>*Note: Make sure that you sort a copy of the list. DO NOT modify the original list. You can create a copy of nums by writing the code new_arr = nums.copy(). In addition, marks will not be given if the selection sort algorithm is not used.*  
#   
#  
# 3.	Define a function **calculate_median**(*nums*):
#   -	***nums***: A *list* of sorted floating numbers.
#   -	**Return**: A *float* representing the median of nums.
#   <br>*Hint: If the length of a sorted list is odd then the median exists at index n//2 where n is the length of the list and // represents integer division. If the length of a sorted list is even, the median is calculated by the average of the two most middle elements. One of these elements exists at index n//2, can you figure out the other one? For example, the median of [1.0,2.0,3.0,4.0] is (3.0+2.0)/2 = 2.5*
#   
#   
# 4. Define a function **main**(*temp_data*):
#   -	***temp_data***: A *list* of *strings* representing a set of daily temperatures. 
#   -	**Return**: A *float* representing the median of nums. Return the *string* "N/A" if an error occurs.

# ---
# ## Implementation
# 
# Please define all functions in the cell below

# In[51]:


# YOUR CODE HERE

def check_iterable(x):
    '''Returns true if x is an iterable, false otherwise'''
    # the method to do this was taken from a stackoverflow post
    # https://stackoverflow.com/questions/1952464/in-python-how-do-i-determine-if-an-object-is-iterable
    try: 
        iter(x)

        # strings are iterables, but we don't want to deal with those either, so return false if the object is a string
        return type(x) != str
    except TypeError:
        return False

def extract_temps(temps):
    '''Takes an input array of temperatures and returns an array with all numbers converted to floats and invalid numbers discarded.'''

    # check if temps is actually an array, if not, return an empty array
    
    if not check_iterable(temps):
        return []

    extracted = []
    # attempt to convert every entry to a float
    # if this fails, we know the entry is not a number and is probably from a day where the temperature was not recorded
    # converted values are added to a new array
    for temp in temps:
        try:
            extracted.append(float(temp))
        except ValueError:
            # most likely one of our string inputs, treat as invalid data (i.e. ignore it)
            pass
    return extracted

def selection_sort(nums):
    '''Sorts the array nums using a selection sort algorithm'''

    if not check_iterable(nums):
        return []

    try:
        working_arr = nums.copy()  # copy the array so we dont modify the original array
    except AttributeError:  # object is a string
        return []
    
    arr_length = len(nums)

    # this is an implementation of the pseudocode provided
    for i in range(arr_length):
        min_index = i

        for j in range(i, arr_length):
            if working_arr[j] < working_arr[min_index]:
                min_index = j
            
        if min_index != i:  
            # swap the values at i and min_index
            working_arr[i], working_arr[min_index] = working_arr[min_index], working_arr[i]

    return working_arr


def calculate_median(nums):
    '''Takes a sorted list and returns the median of the list'''

    if not check_iterable(nums):
        return None

    nums = selection_sort(nums)

    try:  # this block will throw the majority of errors
        length = len(nums)
        midpoint = length // 2  # floor of half of the length

        if length % 2 == 0:  # even number
            # calculate the number at the low midpoint and the high midpoint, then return the average of those numbers

            low_num = nums[midpoint-1]
            high_num = nums[midpoint]
            
            return (low_num + high_num)/2

        else:  # odd number
            num = nums[midpoint]

            # during testing, weird behaviour occured when nums was a list of strings. To counteract that, we will test
            # for string here, and return None if the object is a string
            # in reality this shouldn't be a problem as all strings are removed in extract_temps

            return None if type(num) == str else num

    except (IndexError, TypeError, ZeroDivisionError): # no output on errors, but we need to check if errors occured in main()
        return None

def main(temp_data):
    '''Takes an input array of temperatures and potentially useless data and returns the median temperature'''

    # delete the useless data from the array, sort it, then extract the median

    numerical_data = extract_temps(temp_data)

    if numerical_data != temp_data and numerical_data == []:  # an error occured somewhere in extract_temps and we returned []
        return "N/A"

    # the data is sorted inside calculate_median, so there's no need to sort the array here

    median = calculate_median(numerical_data)

    return "N/A" if median is None else median


# ---
# ## Sample Output
# 

# The following cell provides some sample code for you to test our your code.

# In[52]:


temps = ["5","","5.5","6.2","4.5","N/A","Not Recorded","5.67"]
print("Given Temps:",temps)
print("Median:",main(temps))
print("-----")
temps = ["5","N/A","5"]
print("Given Temps:",temps)
print("Median:",main(temps))
print("-----")
temps = ["-10","",""]
print("Given Temps:",temps)
print("Median:",main(temps))
print("-----")
temps = ["","",""]
print("Given Temps:",temps)
print("Median:",main(temps))

print('\n')

def test1():
    print(extract_temps(["1","NA","5.5"]))

def test2():
    print(extract_temps(['N/A', 'Nope', 'Not', 'A', 'Temperature']))

def test3():
    print(extract_temps([]))

def test4():
    print(extract_temps("not an array lol"))

def test5():
    print(selection_sort([4, 3, 2, 1]))

def test6():
    print(selection_sort([1, 2, 3, 4, 5]))

def test7():
    print(selection_sort([]))

def test8():
    print(selection_sort(["not", "numbers", "hehehhe"]))

def test9():
    print(selection_sort("not an array hehehe"))

def test10():
    print(calculate_median([1,2,3,4,5]))

def test11():
    print(calculate_median([1, 2, 3, 4]))

def test12():
    try:
        print(calculate_median([]))
    except IndexError:
        print("Index Error")

def test13():
    print(calculate_median(['String', 'wow i love strings', 'im probably writing way more tests than are expected? maybe?']))

def test14():
    print(calculate_median(2373274))

test1()
test2()
test3()
test4()
test5()
test6()
test7()
test8()
test9()
test10()
test11()
test12()
test13()
test14()
print("Done")


# The expected output for the previous cell is given below:
# 
# <code>
# Given Temps: ['5', '', '5.5', '6.2', '4.5', 'N/A', 'Not Recorded', '5.67']
# Median: 5.5
# -----
# Given Temps: ['5', 'N/A', '5']
# Median: 5.0
# -----
# Given Temps: ['-10', '', '']
# Median: -10.0
# -----
# Given Temps: ['', '', '']
# Median: N/A
# </code>

# ---
# ## Code Legibility (6 Marks)
# Your code will be marked on commenting and code legibility.<br>
# The mark breakdown is as follows:<br>
# > 2 marks for using appropriate variable names that indicate what is being stored in that variable<br>
# 2 marks for leaving comments on major parts of your code such as where you read the file or calculate a summation<br>
# 2 marks for exception handling. Your functions should produce the required outputs even when receiving unexpected inputs

# ---
# ## Test Plan (6 Marks)
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
# Function: extract_temps(temps)
# Input: temps = ["1","NA","5.5"]  
# Excpected Output: [1.0,5.5]
# Output: [1.0,5.5]
# Pass/Fail: Pass
# ```
# 
# Implement your testing plan in the cell below! 

# ```
# DOUBLE CLICK TO EDIT THIS CELL. DO NOT DELETE QUOTATION MARKS
# 
# Function: extract_temps
# Input: temps = ["1","NA","5.5"]  
# Expected Output: [1.0,5.5]
# Output: [1.0,5.5]
# Pass/Fail: Pass
# 
# Function: extract_temps
# Input: temps = ['N/A', 'Nope', 'Not', 'A', 'Temperature']  
# Expected Output: []
# Output: []
# Pass/Fail: Pass
# 
# Function: extract_temps
# Input: []
# Expected Output: []
# Output: []
# Pass/Fail: Pass
# 
# Function: extract_temps
# Input: "Not an array lol"
# Expected Output: []
# Output: []
# Pass/Fail: Pass
# 
# Function: selection_sort
# Input: [4,3,2,1]
# Expected Output: [1, 2, 3, 4]
# Output: [1, 2, 3, 4]
# Pass/Fail: Pass
# 
# Function: selection_sort
# Input: [1, 2, 3, 4, 5]
# Expected Output: [1, 2, 3, 4, 5]
# Output: Pass
# 
# Function: selection_sort
# Input: []
# Expected Output: []
# Output: Pass
# 
# Function: selection_sort
# Input: ["not", "numbers", "hehehhe"]
# Expected Output: []
# Output: ['hehehhe', 'not', 'numbers']
# Pass/Fail: Fail
# Note: Apparently, > < operators work on characters and strings in python. This means the sort we wrote can (potentially?) act as a alphabetical sort as well. Cool, but not required. This doesn't really effect the functionality of our program (it didn't error), so this test failing isn't a big deal.
# 
# Function: selection_sort
# Input: "not an array hehehe"
# Expected Output: the above string, but alphabetically sorted
# Output: AtributeError
# Pass/Fail: Fail
# Note: You can't copy a string object, so this test fails. Instead, we'll add code to deal with this error, and return an empty array in this case. This passes through our iterable check because a string is an iterable, just not one you can copy.
# 
# Function: calculate_median
# Input: [1, 2, 3, 4, 5]
# Expected Output: 3
# Output: 3
# Pass/Fail: Pass
# 
# Function: calculate_median
# Input: [1, 2, 3, 4]
# Expected Output: 2.5
# Output: 2.5
# Pass/Fail: Pass
# 
# Function: calculate_median
# Input: []
# Expected Output: IndexError
# Output: IndexError
# Pass/Fail: Pass
# Note: Normally, a test throwing an error would be a fail. However, we actually need some functions to throw an error so we can fufil the obejectives of the program (that main() needs to return "N/A" if an error occurs)
# Note2: On second thought, this is not good enough. We will return None when the error occurs, and instead check for None in main()
# 
# Function: calculate_median
# Input: ['string', 'wow i love strings', 'im probably writing way more tests than are expected? maybe?']
# Expected Output: None
# Output: None
# Pass/Fail: Pass
# 
# Function: calculate_median
# Input: 2373274
# Expected Output: None
# Output: None
# Pass/Fail: Pass
# ```

# ---
# ## Reflective Questions
# 
# 1. What input would cause your main() function to return "N/A"?
# 
# 
# 2. Assuming that functions 1-3 are only used inside your main function, is it necessary to use try and except statements inside them to validate input?

# ```
# YOUR ANSWERS HERE. DO NOT DELETE QUOTATION MARKS
# 
# 1. The function will return "N/A" when it is inputed with: Non-iterables, strings, empty arrays, or arrays with only strings in it.
# 
# 2. No, it is not necessary. Input can be validated in the main function. Because I would then control what kind of data enters the functions, I can make sure the functions only have valid inputs and eliminate the need to check inputs.
# ```

# ---
# ## Submission
# 
# Please download this notebook as a .py file (*File* > *Download as* > *Python (.py)*) and submit it to the Computing Lab 7 dropbox on avenue with the naming convention: macID_CL7.py
# 
# **Make sure the final version of your lab runs without errors, otherwise, you will likely recieve zero.**
# 
# This assignment is due the day after your Lab A section at 11:59 PM EST
# 
# Late labs will not be accepted
