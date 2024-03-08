Imports System
Imports System.Collections.Generic
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AnimalCollection
    'This class takes in a text file with an abosolute path as a string and has methods for
    'parsing the animals into a list that can be sorted based on type, sex, or age

    'INPUT- file_path: a string with an absolute path to an animal list text file


    'create a file path attribute'
    Public file_path As String
    'Create a placeholder array for a list of all the animals'
    Private _animalList As New List(Of Animal)()
    Private _sortedList As New List(Of String)()

    ' Define enum sort key for priority search
    Enum SortKey
        Atype
        Asex
        Aage
    End Enum

    Public Sub CollectAnimals()
        'Parses all animal data in the text file given on animal collection initiation'
        Dim fileContent As String = My.Computer.FileSystem.ReadAllText(Me.file_path) 'Read in the data'
        Dim lines() As String = fileContent.Split(Environment.NewLine) 'Parse each line'
        For k As Integer = 0 To lines.Length - 1 Step 4 ' Grab the data in groups of 4 lines'
            If k + 3 < lines.Length Then 'Check each animal has 4 lines of data'
                Dim NameStr As String = (lines(k + 1).Replace(vbCr, "").Replace(vbLf, "")).Trim() 'Parse the name'
                Dim SexStr As String = (lines(k + 2).Replace(vbCr, "").Replace(vbLf, "")).Trim() 'Parse the sex'
                Dim AgeStr As String = (lines(k + 3).Replace(vbCr, "").Replace(vbLf, "")).Trim() 'Parse the Age'
                Dim SexChar As Char = SexStr 'Set string for sex to char'
                Dim AgeInt As Integer = CalculateAge(Integer.Parse(AgeStr)) 'Calculate the age of the animal given the current year'
                If lines(k).Trim() = "Dog" Or lines(k).Trim() = "dog" Then 'Check the animal type'
                    Dim newDog As New Dog(NameStr, SexChar, AgeInt) 'Create a dog'
                    _animalList.Add(newDog) 'Add the dog to the list of collected animals'
                ElseIf lines(k).Trim() = "Cat" Or lines(k).Trim() = "cat" Then 'Check the animal type'
                    Dim newCat As New Cat(NameStr, SexChar, AgeInt) 'Create a cat'
                    _animalList.Add(newCat) 'Add the cat to the list of collected animals'
                End If
            ElseIf lines(k) = "" Or IsNothing(lines(k)) Then 'Check if a given text line is empty'
                Console.WriteLine("Warning: Empty Line at k") 'This means we are skipping an animal due to text file errors
            Else ' Check if the file ended or there is some other data'
                Console.WriteLine("End of file after " & k / 4 & " animals.") 'Output animals found'
            End If

        Next
    End Sub


    Public Sub SortAnimals(key, key_qualifier)
        'Sorts animals parsed from the text file given specific attributes. It sorts them and dumps them into a list'

        'INPUT- key: an enum that defines the type of search and sort to be done, type, sex, or age
        '       key_qualifer: variable that can be string or char. Determines specific type or sex desired (not used by age sort)

        _sortedList.Clear() ' Clear the current list
        Dim AgeSortedList As New List(Of Integer) ' initialize a list if using age sort for sorting ages in ascening order

        For k As Integer = 0 To _animalList.Count - 1 'Iterate over the list of animals'
            Dim one_Animal As Animal = _animalList(k) 'take one animal out'
            Dim TypeStr As String
            Dim NameStr As String
            Dim SexChar As String
            Dim AgeStr As String
            Select Case key 'Deterime the sort type'
                Case SortKey.Atype
                    If one_Animal.GetAnimalType() = key_qualifier Then
                        TypeStr = one_Animal.GetAnimalType()
                        NameStr = one_Animal.GetName()
                        _sortedList.Add(NameStr & " is a " & TypeStr) 'Assign a string according the desired sort find for the given type'
                    End If

                Case SortKey.Asex
                    If one_Animal.GetSex() = key_qualifier Then
                        SexChar = one_Animal.GetSex()
                        NameStr = one_Animal.GetName()
                        If SexChar = "m"c Then
                            _sortedList.Add(NameStr & " is a Male") 'Assign a string according the desired sort find for the given sex'
                        ElseIf SexChar = "f"c Then
                            _sortedList.Add(NameStr & " is a Female") 'Assign a string according the desired sort find for the given sex'
                        End If

                    End If

                Case SortKey.Aage
                    Dim AgeInt As Integer = one_Animal.GetAge()
                    AgeStr = AgeInt.ToString()
                    NameStr = one_Animal.GetName()
                    _sortedList.Add(NameStr & " is " & AgeStr & " years old") 'Assign a string according the desired sort find for the age'
                    AgeSortedList.Add(AgeInt) 'store the age in a separate list for easy sorting'
            End Select
        Next

        If key = SortKey.Aage Then 'Check if we sorted by age so we can resort items in ascending order'
            Dim indices As New List(Of Integer) 'create a list of indices for reasigning the orignal array
            For k As Integer = 0 To AgeSortedList.Count - 1
                indices.Add(k)
            Next
            indices.Sort(Function(x, y) AgeSortedList(x).CompareTo(AgeSortedList(y))) 'sort the indices based on how we should sort the ages'

            Dim tempList As New List(Of String)() 'Create a temporary list for reasigning the output sorted list'

            For Each index As Integer In indices
                tempList.Add(_sortedList(index))
            Next

            _sortedList = tempList 'reasign the sorted list to the sorted by ascending age list
        Else
            _sortedList.Sort() ' if not sorting by age sort alphabetically
        End If

    End Sub

    Private Function CalculateAge(birthyear)
        'Finds the age of the given animal based on the current year and its birthyear'
        Dim Age As Integer = DateTime.Now.Year - birthyear 'find the age'
        If Age < 0 Then 'Check the age is possible'
            Throw New ArgumentException("Animal Age can't be less 0 years old. Check Animal Data")
        End If
        Return Age
    End Function


    Public Function DeliverAnimals()
        'Gives the sorted list to a handler. Can be empty and will return an empty list'
        Return _sortedList
    End Function


    Public Sub New(file_path As String)
        'Constructor - initializes animal collection object given a file_path string
        Me.file_path = file_path
    End Sub


End Class
