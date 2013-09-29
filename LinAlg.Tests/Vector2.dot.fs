module LinAlg.Tests

open NUnit.Framework
open LinAlg.Math

[<TestFixture>]
type Vector2dot() =

    [<Test>]
    member self.perpendicular_vectors_have_zero_dot_product() =
        let v = Vector2(1.,0.)
        let u = Vector2(0.,1.)
        let s = dot v u
        Assert.AreEqual(0., s)