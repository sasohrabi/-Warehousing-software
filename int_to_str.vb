Imports vb = Microsoft.VisualBasic

Module int_to_str

    Function Adad(ByVal Number As Double) As String
        If Number = 0 Then
            Adad = "���"
        End If
        Dim Flag As Boolean
        Dim S As String
        Dim I, L As Byte
        Dim K(5) As Double

        S = Trim(Str(Number))
        L = Len(S)
        If L > 15 Then
            Adad = "����� ��ѐ"
            Exit Function
        End If
        For I = 1 To 15 - L
            S = "0" & S
        Next I
        For I = 1 To Int((L / 3) + 0.99)
            K(5 - I + 1) = Val(Mid(S, 3 * (5 - I) + 1, 3))
        Next I
        Flag = False
        S = ""
        For I = 1 To 5
            If K(I) <> 0 Then
                Select Case I
                    Case 1
                        S = S & Three(K(I)) & " �������"
                        Flag = True
                    Case 2
                        S = S & IIf(Flag = True, " � ", "") & Three(K(I)) & " �������"
                        Flag = True
                    Case 3
                        S = S & IIf(Flag = True, " � ", "") & Three(K(I)) & " ������"
                        Flag = True
                    Case 4
                        S = S & IIf(Flag = True, " � ", "") & Three(K(I)) & " ����"
                        Flag = True
                    Case 5
                        S = S & IIf(Flag = True, " � ", "") & Three(K(I))
                End Select
            End If
        Next I
        Adad = S
    End Function

    Function Three(ByVal Number As Integer) As String
        Dim S As String
        Dim I, L As Long
        Dim h(3) As Byte
        Dim Flag As Boolean
        L = Len(Trim(Str(Number)))
        If Number = 0 Then
            Three = ""
            Exit Function
        End If
        If Number = 100 Then
            Three = "����"
            Exit Function
        End If

        If L = 2 Then h(1) = 0
        If L = 1 Then
            h(1) = 0
            h(2) = 0
        End If

        For I = 1 To L
            h(3 - I + 1) = Mid(Trim(Str(Number)), L - I + 1, 1)
        Next I

        Select Case h(1)
            Case 1
                S = "����"
            Case 2
                S = "�����"
            Case 3
                S = "����"
            Case 4
                S = "������"
            Case 5
                S = "�����"
            Case 6
                S = "����"
            Case 7
                S = "�����"
            Case 8
                S = "�����"
            Case 9
                S = "����"
        End Select

        Select Case h(2)
            Case 1
                Select Case h(3)
                    Case 0
                        S = S & " � " & "��"
                    Case 1
                        S = S & " � " & "�����"
                    Case 2
                        S = S & " � " & "������"
                    Case 3
                        S = S & " � " & "�����"
                    Case 4
                        S = S & " � " & "������"
                    Case 5
                        S = S & " � " & "������"
                    Case 6
                        S = S & " � " & "������"
                    Case 7
                        S = S & " � " & "����"
                    Case 8
                        S = S & " � " & "����"
                    Case 9
                        S = S & " � " & "�����"
                End Select

            Case 2
                S = S & " � " & "����"
            Case 3
                S = S & " � " & "��"
            Case 4
                S = S & " � " & "���"
            Case 5
                S = S & " � " & "�����"
            Case 6
                S = S & " � " & "���"
            Case 7
                S = S & " � " & "�����"
            Case 8
                S = S & " � " & "�����"
            Case 9
                S = S & " � " & "���"
        End Select

        If h(2) <> 1 Then
            Select Case h(3)
                Case 1
                    S = S & " � " & "��"
                Case 2
                    S = S & " � " & "��"
                Case 3
                    S = S & " � " & "��"
                Case 4
                    S = S & " � " & "����"
                Case 5
                    S = S & " � " & "���"
                Case 6
                    S = S & " � " & "��"
                Case 7
                    S = S & " � " & "���"
                Case 8
                    S = S & " � " & "���"
                Case 9
                    S = S & " � " & "��"
            End Select
        End If
        S = IIf(L < 3, vb.Right(S, Len(S) - 3), S)
        Three = S
    End Function


End Module
