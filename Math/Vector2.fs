module LinAlg.Math

    type Vector2(x: float, y: float) =
        member this.x = x
        member this.y = y
        static member (~-) (v : Vector2) =
            -1. * v
        static member (*) (a, v: Vector2) =
            Vector2(a * v.x, a * v.y)
        static member (*) (v : Vector2, a) =
            a * v
        static member (/) (v : Vector2, a) =
            (1. / a) * v
        static member (+) (v : Vector2, u : Vector2) =
            Vector2(v.x + u.x, v.y + u.y)
        static member (-) (v : Vector2, u : Vector2) =
            v + (-u)
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

    let isPerpendicular (v:Vector2) (u:Vector2) =
        dot v u = 0.