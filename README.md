# Football-Course-Project

-- Basic Requirements

Develop ball with autographs class class library 

You have a football and collect autographs of football players on it.
Note:Usually the ball cover consists of 32 panels (20 white hexagonal and 12 black pentagonal ones).

Methods:
1.Add an autograph.
2.Return a list of existing autographs
3.Return the number of free white panels of the ball

-- Detailed Requirements

1.Create a new Football
	1.1 If the Football is not found an exception is thrown
	1.2 If the Football is found it add an autograph and Football is added
2.Adding an autograph is added
	2.1 If Football is not found an exception is thrown
	2.2 If the Football is full an exception is thrown
	2.3 If Football is found and not full autograph is added and Football is returned
3.Retrieve a Football by id
	3.1 If Football is not found an exception is thrown 
	3.2 If Football is found Football is returned
4.Retrieve all Footballs
5.Clean Football
	5.1 If Football is not found an exception is thrown 
	5.2 If Football is found autograph are removed