Imports Microsoft.VisualBasic

Module ShamsiDate
    Function TarikhShamsi(Optional ByRef date1 As String = "", Optional ByRef SmallDate1 As Boolean = False) As String

        '====================================================
        Dim Ds, P1, Ms, i, rp, u, Mm, w, d, p, mon, Ym, v, x, Ys, Dm, D1, DateShamsi As Object
        d = New Object() {20, 19, 20, 20, 21, 21, 22, 22, 22, 22, 21, 21}
        p = New Object() {11, 12, 10, 12, 11, 11, 10, 10, 10, 9, 10, 10}
        w = New Object() {"Ìﬂ‘‰»Â", "œÊ‘‰»Â", "”Â ‘‰»Â", "çÂ«—‘‰»Â", "Å‰Ã‘‰»Â", "Ã„⁄Â", "‘‰»Â"}

        If SmallDate1 = True Then
            mon = New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"}
        Else
            mon = New Object() {"›—Ê—œÌ‰", "«—œÌ»Â‘ ", "Œ—œ«œ", " Ì—", "„—œ«œ", "‘Â—ÌÊ—", "„Â—", "¬»«‰", "¬–—", "œÌ", "»Â„‰", "«”›‰œ"}
        End If

        If date1 = "" Then date1 = CStr(Today)

        Dm = Day(CDate(date1))
        Mm = Month(CDate(date1))
        Ym = Year(CDate(date1))
        u = 0
        rp = 0
        If (Ym Mod 4) = 0 Then u = 1
        If ((Ym Mod 100) = 0 And (Ym Mod 400) <> 0) Then u = 0
        Ys = Ym - 622
        x = Ys - 22
        x = x Mod 33
        If ((x Mod 4) = 0 And x <> 32) Then rp = 1
        i = Not (rp - 2) + Not (u - 2) * 2
        x = 0
        If (i = 0 And Mm = 3) Then x = 1
        If i = 0 Then i = 3
        Ms = (9 + Mm) Mod 13
        If Ms < 10 Then Ms = Ms + 1
        D1 = d(Mm - 1)
        If (i = 1 And Mm > 2) Then D1 = D1 - 1
        If (i = 2 And Mm < 3) Then D1 = D1 - 1
        P1 = p(Mm - 1)
        If (i = 1 And Mm > 2) Then P1 = P1 + 1
        If (i = 2 And Mm < 4) Then P1 = P1 + 1
        If (Dm > 0 And Dm <= D1) Then
            Ds = P1 + Dm + x - 1
            x = 1
        Else
            Ds = Dm - D1
            Ms = Ms + 1
            If Ms = 13 Then Ms = 1
            x = 2
        End If
        If ((Mm = 3 And x = 2) Or Mm > 3) Then Ys = Ys + 1
        If SmallDate1 = True Then
            TarikhShamsi = Trim(Str(Ys)) & "/" & Trim(mon(Ms - 1)) & "/" & Trim(Str(Ds))
        Else
            TarikhShamsi = w(Weekday(Today) - 1) + " " + Str(Ds) + " " + mon(Ms - 1) + " " + Str(Ys)
        End If

    End Function

    Function MthGetdateMilady(ByRef YY_MM_DD As String) As String

        Dim i As Object
        Dim sh_mm, sh_yy, sh_dd As Short
        Dim md_dd, md_yy, md_mm As Short
        Dim t_date As Single
        Dim md_dd1, md_yy1, md_mm1 As String
        Dim md_mon(12) As Short
        Dim sh_mon(12) As Short
        Dim md_date As String
        Dim t_mm As Short
        Dim t_day As Single

        If Len(YY_MM_DD) <> 8 Then
            MsgBox("Œÿ« - - -  «—ÌŒ —« »’Ê—  —Ê“/„«Â/”«· Ê«—œ ‰„«ÌÌœ")
            Exit Function
        End If

        YY_MM_DD = "13" & Mid(YY_MM_DD, 1, 8)
        sh_yy = Val(Mid(YY_MM_DD, 1, 4))
        sh_mm = Val(Mid(YY_MM_DD, 6, 2))
        sh_dd = Val(Mid(YY_MM_DD, 9, 2))

        If sh_yy < 1300 Then
            MsgBox("Œÿ« - - - ”«· —« ‘„”Ì Ê«—œ ‰„«ÌÌœ")
        End If

        If sh_mm < 1 Or sh_mm > 12 Then
            MsgBox("Œÿ«  - - - „«Â —« œ—”  Ê«—œ ‰„«ÌÌœ")
        End If

        md_mon(1) = 31
        md_mon(2) = 28
        md_mon(3) = 31
        md_mon(4) = 30
        md_mon(5) = 31
        md_mon(6) = 30
        md_mon(7) = 31
        md_mon(8) = 31
        md_mon(9) = 30
        md_mon(10) = 31
        md_mon(11) = 30
        md_mon(12) = 31

        sh_mon(1) = 31
        sh_mon(2) = 31
        sh_mon(3) = 31
        sh_mon(4) = 31
        sh_mon(5) = 31
        sh_mon(6) = 31
        sh_mon(7) = 30
        sh_mon(8) = 30
        sh_mon(9) = 30
        sh_mon(10) = 30
        sh_mon(11) = 30
        sh_mon(12) = 29

        t_mm = 0
        md_mm = 1

        t_date = (226898 - 154) / 365
        md_yy = Int(t_date) + sh_yy

        If (sh_yy Mod 4) = 3 Then
            sh_mon(12) = sh_mon(12) + 1
            md_mon(2) = md_mon(2) + 1
        End If
        If sh_dd > sh_mon(sh_mm) Or sh_dd < 1 Then
            MsgBox("xxxxxxxxx1")
        End If

        For i = 1 To sh_mm - 1
            t_mm = t_mm + sh_mon(i)
        Next

        t_day = ((t_date - Int(t_date)) * 365) + t_mm + sh_dd

        i = 1
        Do While t_day > md_mon(i)
            t_day = t_day - md_mon(i)
            md_mm = md_mm + 1
            i = i + 1
            If i = 13 Then
                If Int(t_day) <> 0 Then
                    i = 1
                    md_mm = 1
                    md_yy = md_yy + 1
                    If md_mon(2) = 29 Then
                        md_mon(2) = 28
                    End If
                    If (md_yy Mod 4) = 0 Then
                        md_mon(2) = 29
                    End If
                Else
                    md_mm = 12
                    t_day = md_mon(12)
                    Exit Do
                End If
            End If
        Loop

        If Int(t_day) = 0 Then
            md_mm = md_mm - 1
            t_day = md_mon(md_mm)
        End If

        md_dd = t_day

        md_dd1 = Str(md_dd)
        md_mm1 = Str(md_mm)
        md_yy1 = Str(md_yy)

        If Val(md_dd1) < 10 Then
            md_dd1 = "0" & Trim(md_dd1)
        End If
        If Val(md_mm1) < 10 Then
            md_mm1 = "0" & Trim(md_mm1)
        End If

        MthGetdateMilady = Trim(md_yy1) & "/" & Trim(md_mm1) & "/" & Trim(md_dd1)

    End Function


End Module
