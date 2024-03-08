Public MustInherit Class Animal
    'An abstract class takes for parenting animals. Holds information for the
    'Animaltype, name, sex, and year of birth. Will return private types for 
    'Child classes. 


    'Define attributes
    Private _animalType As String
    Private _name As String
    Private _sex As Char
    Private _yearOfBirth As Integer

    ' Create Abstract methods
    Public Function GetAnimalType() As String
        Return _animalType
    End Function

    Public Overridable Sub SetAnimalType(animalType As String)
        _animalType = animalType
    End Sub

    Public Function GetName() As String
        Return _name
    End Function

    Public Overridable Sub SetName(name As String)
        _name = name
    End Sub
    Public Function GetSex() As Char
        Return _sex
    End Function
    Public Overridable Sub SetSex(sex As Char)
        If sex = "m"c Or sex = "f"c Then 'check that sex is given as male or female'
            _sex = sex
        Else
            Throw New ArgumentException("Sex must be 'm' or 'f'.")
        End If
    End Sub

    Public Function GetAge() As Integer
        Return _yearOfBirth
    End Function

    Public Overridable Sub SetAge(yearOfBirth As Integer)
        _yearOfBirth = yearOfBirth
    End Sub



    Public Sub New(animalType As String, name As String, sex As Char, yearOfBirth As Integer)
        'Constructor - builds an internal animal class for a child with a given, type, name, sex, and age'
        SetAnimalType(animalType)
        SetName(name)
        SetSex(sex)
        SetAge(yearOfBirth)
    End Sub



End Class
