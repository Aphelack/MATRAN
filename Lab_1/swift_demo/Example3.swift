import Foundation

struct Point {
    var x: Int
    var y: Int

    func distanceSquared() -> Int {
        return x * x + y * y
    }
}

func factorial(_ n: Int) -> Int {
    if n <= 1 {
        return 1
    }
    return n * factorial(n - 1)
}

let p = Point(x: 3, y: 4)
let d2 = p.distanceSquared()
let fact = factorial(5)

print("d2:", d2)
print("fact:", fact)
