module LinAlg.Math
    type Vector(x: float, y: float) =
        member this.x = x
        member this.y = y
        static member (~-) (v : Vector) =
            Vector(-1.0 * v.x, -1.0 * v.y)
        static member (*) (v : Vector, a) =
            Vector(a * v.x, a * v.y)
        static member (*) (a, v: Vector) =
            Vector(a * v.x, a * v.y)
        override this.ToString() =
            this.x.ToString() + " " + this.y.ToString()

    type Vector3(x: float, y: float, z: float) =
        member this.x = x
        member this.y = y
        member this.z = z
        override this.ToString() =
            this.x.ToString() + " " + this.y.ToString() + " " + this.z.ToString()


    let dot (v:Vector) (u:Vector) =
        v.x * u.x + v.y * u.y

    let cross (v:Vector3) (u:Vector3) =
        let x = v.y*u.z + v.z*u.y
        let y = v.x*u.z + v.z*u.x
        let z = v.x*u.y + v.y*u.x
        Vector3(x, y, z)