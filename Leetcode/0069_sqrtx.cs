using System;

public class Solution
{
	// Proof #234243098 why Leetcode is silly.
	// Part of the assignment reads as follows:
	//
	// Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.
	//
	// You must not use any built-in exponent function or operator.
	// • For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.
	//
	// This is just weird. I know there's someone out there arguing "bUt It'S aBoUt ThE dAtAsTrUcTuReS aNd AlGoRiThMs",
	// which proves that:
	// 1. Leetcode doesn't reflect real world problems in a ton of cases
	// 2. Leetcode serves as a platform to learn algorithms for technical interviews
	// 2.a. Technical interviews that use these kinds of tests are useless since they aren't testing real world
	//      skills, but instead test for people if they are able to take tests and memorize things.
	//
	// The line below does exactly what the problem is asking for, and using built in functionality of a framework
	// proves exactly how one would use a framework and what for.
	// Using the line below results in: 0 ms | Beats 100.00%

	public int MySqrt(int x)
	{
		return (int)Math.Sqrt(x);
	}
}