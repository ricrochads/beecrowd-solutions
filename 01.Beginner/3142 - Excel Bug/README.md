# 3142 - Excel Bug

While our birthday boy was exchanging balloons, he received an email from a professor asking to urgently send some additional statistical data to report on a project in which he participates.

Tobias promptly opened the Excel spreadsheet where the data was saved to make the necessary accounts and send the requested data as quickly as possible. The sooner he finishes this task, the more time he has left to enjoy his birthday.

In Excel, each column in the spreadsheet is indicated by letters. The first column is the letter "A", the second column is the letter "B", the third "C" and so on to "Z", where the next column is "AA". Then comes "AB", "AC", "AD", ..., up to "AZ". Hence "BA", "BB", "BC", ..., and so on to "ZZ". Then comes "AAA", "AAB", ..., until you reach "XFD", which is the last column of the spreadsheet. (Yes, there is one last column! Sorry to destroy the dream of anyone who thought it was infinite).

In Excel, there are also formulas that perform specific operations and can take spreadsheet cells as parameters. One of these formulas is =COL(), which if called without parameters returns the numeric position of the column in which it was called. For example, calling the function =COL() on any line in column “A” would return 1. Calling in column “D” would return 4, in column “Z” it would return 26, in column “AB” it would return 28 and so on .

When trying to perform the necessary operations to recover the requested data, Tobias noticed that the formula =COL() was not working.

Can you help him solve this problem by writing an algorithm that, given the set of letters that identifies the column, returns to its numerical position? As he is in a bit of a hurry to finish this, it is possible that he accidentally typed in some column code that does not exist (outside the “A” - “XFD” range), in which case you should warn him about it.

**Input**<br>
You will be asked to answer several test cases. Each test case has a line with an **S** (1 ≤ |**S**| ≤ 10) string that contains the sequence of letters that identify the column. **S** is guaranteed to have only uppercase letters ('A' - 'Z').

The entry ends with EOF.

**Output**<br>
For each test case, print an integer containing the numeric index value for that column. If the column code entered is not within the limits of Excel, print *“Essa coluna nao existe Tobias!”* (without quotes).

| Input Sample                     | Output Sample                                                |
|:---------------------------------|:-------------------------------------------------------------|
| A <br> D <br> Z <br> ZZZ <br> AB | 1 <br> 4 <br> 26 <br> Essa coluna nao existe Tobias! <br> 28 |