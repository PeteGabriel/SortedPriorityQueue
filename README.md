# Sorted Priority Queue data structure 

## The idea:

Given a priority queue, it's easy to build a sorting algorithm: just enqueue everything into the priority
queue and then dequeue everything. It turns out that the converse is also possible – given a sorting algorithm,
it's possible to construct an efficient priority queue that's internally backed by that sorting algorithm.
There are a number of constructions that make this possible, most of which assume that the data
are integers and many of which use a number of clever techniques.

## Why this ?

In trying to convert from a black-box sorting algorithm to a priority
queue, it's often important to reason about the specific model of computation being used. Depending on
whether randomization is permitted or what restrictions there are on the sorts of bitwise operations can be
performed by the machine in constant time, the slowdown introduced in the construction can vary widely.
If you're interested in both seeing a cool construction and learning about models of computation in the
context of data structure design, this would be a great place to start.

### Credits

This idea was taken from a "Suggested Final Project Topics" paper from a certain university computer science course which name I can't recall, although was completely public.

My decisions during the development of this project were heavily influenced by the book ["The Algorithm Design Manual"](https://books.google.pt/books?id=7XUSn0IKQEgC&printsec=frontcover&hl=pt-PT#v=onepage&q&f=false).


## Priority Queue

A queue is a data structure that follows the pattern of FIFO (First in, First out). It is used in situations when the order is important. Usually, a queue have the following interface:

* Enqueue(x, q): Insert item _x_ at the back of queue _q_.
* Dequeue(q): Return (and remove) the front item from queue _q_.

The difference between a _priority queue_ and a simple _queue_ is that the elements inside the first are sorted accordingly with some predicate that expresses how the concept of priority must be understood by the data structure. This means that the first to enter is not necessarily the first to be retrieved.

## Sorting algorithms complexity 

When I thought about doing this project, I had to contemplate a few algorithms to use in order to back my data structure. The following table shows the complexity for those that made to the final stage of my decision.  

| Algorithm 	| Worst Time Complexity 	| SpaceComplexity 	|
|:---------:	|:---------------------:	|:---------------:	|
| Quicksort 	|         O(n^2)        	|    O(log(n))    	|
| Mergesort 	|      O(n log(n))      	|       O(n)      	|
|  Heapsort 	|      O(n log(n))      	|       O(1)      	|

It seems right to think that Heapsort is the valid choice for this project. It doesn't require any extra space and it does not holds the worst performance either. Let's see the main idea behind this algorithm.

## Heapsort Algorithm

* Comparison-based sorting algorithm


tbc..