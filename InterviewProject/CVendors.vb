<Serializable()> Public Class CVenders
    Inherits CollectionBase

    Public Event Dirty(ByVal DataDirty As Boolean)

    Public Function Add(ByVal lobjVen As CVender) As Integer
        Return MyBase.List.Add(lobjVen)
    End Function

    ''' <summary>
    ''' Item property that takes an integer as a key, 
    ''' </summary>
    ''' <param name="Key">Zero based</param>
    Default Public Overridable Property Item(ByVal Key As Integer) As Object
        Get
            Return DirectCast(MyBase.List.Item(Key), Object)
        End Get
        Set(ByVal value As Object)
            MyBase.List.Item(Key) = value
        End Set
    End Property

    Public Sub Remove(ByVal pnID As Integer)
        If MyBase.List.Contains(Item(pnID)) Then
            Dim lobjAxis As CVender = Item(pnID)

            MyBase.List.Remove(lobjAxis)
        End If
    End Sub

    Public Sub GetVendors()
        'Added State, Zip, and Phone and 3 other data point
        Add(New CVender("Ackme", "256 S. May", "Oklahoma City", 25, 73108, 4558213))
        Add(New CVender("BrickStone", "346 N. Broadway", "Oklahoma City", 25, 73102, 6524981))
        Add(New CVender("FooBar", "3465 E. Dumbar", "Oklahoma City", 25, 73120, 3219876))
        Add(New CVender("MeterCo", "Windcrest Ln.", "Fort Worth", 43, 76133, 7536418))
        Add(New CVender("GramInc", "Creighton Rd.", "Pensacola", 9, 32504, 1595364))
        Add(New CVender("LiterLlc", "Montreal Dr.", "Hurst", 43, 76054, 8528996))
        Add(New CVender("OrionNet Systems", "1209 E Hefner Rd.", "Oklahoma City", 25, 73131, 2861674))
        Add(New CVender("University of Oklahoma", "1000 Asp Ave", "Norman", 25, 73019, 3252151))
        Add(New CVender("Tulsa Community College", "10300 E 81st St", "Tulsa", 25, 74133, 5957000))

    End Sub

    'Handler of the sub items and class dirty property
    Private Sub HandleDirty(ByVal DataDirty As Boolean)
        RaiseEvent Dirty(DataDirty)
    End Sub
End Class
