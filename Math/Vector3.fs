module Linalg.Math

    type Vector3(x: float, y: float, z: float) =
        member this.x = x
        member this.y = y
        member this.z = z
        override this.ToString() =
            this.x.ToString() + " " + this.y.ToString() + " " + this.z.ToString()

    let dot (v:Vector3) (u:Vector3) =
        v.x * u.x + v.y * u.y + v.z * u.z

    let cross (v:Vector3) (u:Vector3) =
        let x = v.y*u.z + v.z*u.y
        let y = v.x*u.z + v.z*u.x
        let z = v.x*u.y + v.y*u.x
        Vector3(x, y, z)