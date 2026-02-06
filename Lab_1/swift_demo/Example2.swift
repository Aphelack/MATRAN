import Foundation

let numbers: [Int] = [1, 2, 3, 4, 5]
var squares: [Int] = []

for n in numbers {
    squares.append(n * n)
}

var dict: [String: Int] = ["one": 1, "two": 2]

var i = 0
repeat {
    i += 1
} while i < 3

print("squares:", squares)
print("dict:", dict)

