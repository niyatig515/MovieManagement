# DSA Practice Repository

This repository contains solutions to various Data Structures and Algorithms (DSA) problems that I have practiced. Each problem is listed below with its description and example inputs/outputs.

# 1. Top K Frequent Ads

You are given a list of ad names ads[] where each ad is shown multiple times. Your task is to return the top K most frequently shown ads. If two ads have the same frequency, return the ad that comes first alphabetically in descending order.

Assumptions:

Each ad name is a string.

If two or more ads have the same frequency, the one that appears later lexicographically (alphabetically) should appear earlier in the result.

1 <= ads.length <= 100000

1 <= K <= 100000

Each ad name is between 1 and 20 characters long.

Example:

Input:

ads = ["ad1", "ad2", "ad3", "ad1", "ad3", "ad1", "ad3", "ad2"]
K = 2

Output:

["ad3", "ad1"]

# 2. Swap for Longest Repeated Character Substring (Leetcode 1156)

You are given a string text. You can swap two of the characters in the text.

Return the length of the longest substring with repeated characters.

# 3. Group Anagrams (Leetcode 49)

Given an array of strings, group the anagrams together.

Assumptions:

All inputs are lowercase letters.

The order of output does not matter.

Example:

Input:

strs = ["eat","tea","tan","ate","nat","bat"]

Output:

[
  ["eat","tea","ate"],
  ["tan","nat"],
  ["bat"]
]

# 4. Longest Repeating Character Replacement (Leetcode 424)

You are given a string s and an integer k. You can choose any character of the string and change it to any other uppercase English character. You can perform this operation at most k times.

Return the length of the longest substring containing the same letter you can get after performing the above operations.

# 5. Longest Duplicate Substring (Leetcode 1044)

Given a string s, consider all duplicated substrings (contiguous substrings of s that occur 2 or more times). The occurrences may overlap.

Return any duplicated substring that has the longest possible length. If s does not have a duplicated substring, return "".

# 6. Smallest-to-Second-Highest Swap in a String

You are given a string S consisting of digits. Your task is to extract all non-overlapping consecutive two-digit numbers from S. Among these extracted numbers, identify the smallest and the second-highest values. Replace the first occurrence of the second-highest two-digit number in S with the smallest two-digit number, ensuring that the replacement maintains the two-digit format.

Example:
Input: S = "0332331"
Output: "0303331"

# 7. Rotate Array (Leetcode 189)

Given an array, rotate the array to the right by k steps, where k is non-negative.

Assumptions:

1 <= nums.length <= 10^5

k is a non-negative integer.

Example:

Input:

nums = [1,2,3,4,5,6,7], k = 3

Output:

[5,6,7,1,2,3,4]

# 8. Longest Substring Without Repeating Characters (Leetcode 3)

Given a string, find the length of the longest substring without repeating characters.

Example:

Input:

s = "abcabcbb"

Output:

3

Explanation: The answer is "abc", with the length of 3.

# 9. Minimum Window Substring (Leetcode 76)

Given two strings s and t, return the minimum window in s which will contain all the characters in t. If there is no such window, return the empty string "".

Example:

Input:

s = "ADOBECODEBANC", t = "ABC"

Output:

"BANC"

# 10. Check If Two String Arrays are Equivalent (Leetcode 1662)

Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.

A string is represented by an array if the array elements concatenated in order form the string.

# 11. Maximum Value of a String in an Array (Leetcode 2496)

The value of an alphanumeric string can be defined as:

The numeric representation of the string in base 10 if it comprises digits only.

The length of the string otherwise.

Given an array strs of alphanumeric strings, return the maximum value of any string in strs.

# 12. Number of Different Integers in a String (Leetcode 1805)

You are given a string word that consists of digits and lowercase English letters.

Replace every non-digit character with a space and count the number of different integers present in the string.

Example:

Input:

word = "a123bc34d8ef34"

Output:

3

Explanation: The extracted numbers are 123, 34, and 8. Since 34 appears twice, we count it only once.

