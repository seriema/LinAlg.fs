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
        static member (/) (v : Vector, a) =
            Vector(v.x / a, v.y / a)
        static member (-) (v : Vector, u : Vector) =
            Vector(v.x - u.x, v.y - u.y)
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

    let norm (v:Vector) =
        sqrt v.x**2. + v.y**2.

    let normalize (v:Vector) =
        v / norm v

    let proj (v:Vector) (u:Vector) =
        ((dot u v) / (norm v ** 2.)) * v

    let prep (v:Vector) (u:Vector) =
        u - proj v u

//    let dot (v:Vector3) (u:Vector3) =
//        v.x * u.x + v.y * u.y + v.z * u.z

    let cross (v:Vector3) (u:Vector3) =
        let x = v.y*u.z + v.z*u.y
        let y = v.x*u.z + v.z*u.x
        let z = v.x*u.y + v.y*u.x
        Vector3(x, y, z)