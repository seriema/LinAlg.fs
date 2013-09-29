module LinAlg.Math

    type Vector2(x: float, y: float) =
        member this.x = x
        member this.y = y
        static member (~-) (v : Vector2) =
            Vector2(-1.0 * v.x, -1.0 * v.y)
        static member (*) (v : Vector2, a) =
            Vector2(a * v.x, a * v.y)
        static member (*) (a, v: Vector2) =
            Vector2(a * v.x, a * v.y)
        static member (/) (v : Vector2, a) =
            Vector2(v.x / a, v.y / a)
        static member (-) (v : Vector2, u : Vector2) =
            Vector2(v.x - u.x, v.y - u.y)
        override this.ToString() =
            this.x.ToString() + " " + this.y.ToString()


    // Dependent on dimension

    let dot (v:Vector2) (u:Vector2) =
        v.x * u.x + v.y * u.y

    let norm (v:Vector2) =
        sqrt v.x**2. + v.y**2.


    // Not dependent on dimension

    let normalize (v:Vector2) =
        v / norm v

    let proj (v:Vector2) (u:Vector2) =
        ((dot u v) / (norm v ** 2.)) * v

    let prep (v:Vector2) (u:Vector2) =
        u - proj v u
