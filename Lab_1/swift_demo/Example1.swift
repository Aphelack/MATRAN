import Foundation

let intConst: Int = 5
var doubleVar: Double = 2.5
let boolConst: Bool = true
let charConst: Character = "A"
let textConst: String = "Swift"

let sum = intConst + 3
let product = doubleVar * 4.0

if sum > 5 && boolConst {
    print("sum больше 5")
} else {
    print("sum меньше или равно 5")
}

switch textConst {
case "Swift":
    print("Язык Swift")
case "F#":
    print("Язык F#")
default:
    print("Другой язык")
}
