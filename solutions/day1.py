# Part 1 solution: 1184
# Part 2 solution: 1155
import os


def main():
	part1()
	part2()

def part1():
	solution = 0
	previous = ''

	with open('./input/day1.txt') as f:
		l = f.readline()
		while (l):
			if l > previous:
				solution += 1
			previous = l
			l = f.readline()

	print(f'Solution to part 1: {solution}')


def part2():
	solution = 0
	with open('./input/day1.txt') as f:
		w = f.readline()
		x = f.readline()
		y = f.readline()
		z = f.readline()
		while (z):
			s = int(w) + int(x) + int(y)
			t = int(x) + int(y) + int(z)
			if (t > s):
				solution += 1
			w = x
			x = y
			y = z
			z = f.readline()
	print(f'Solution to part 2: {solution}')


if __name__ == '__main__':
	main()