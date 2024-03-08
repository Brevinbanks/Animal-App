Public Class Dog
    'Creates a Dog animal object inheriting from Animal'
    Inherits Animal

    ' Constructor
    Public Sub New(name As String, sex As Char, yearOfBirth As Integer)
        'Constructor - Makes the type Dog and unchangable'
        MyBase.New("Dog", name, sex, yearOfBirth)
    End Sub

    Public Overrides Sub SetName(name As String)
        MyBase.SetName(name)
    End Sub


    Public Overrides Sub SetSex(sex As Char)
        MyBase.SetSex(sex)
    End Sub


    Public Overrides Sub SetAge(age As Integer)
        MyBase.SetAge(age)
    End Sub

End Class