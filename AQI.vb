
Public Class Form1


    Public A As Single, B As Single, C As Single, D As Single, X1 As Single, X2 As Single, G As Single, H As Single, I As Single, J As Single,
        MAX As Single





    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Length = 0 Then
            TextBox1.Text = "0"
        End If
        A = TextBox1.Text
        If A >= 0 And A < 50 Then
            B = 1 * A
        ElseIf A >= 50 And A < 100 Then
            B = 0.5 * (A - 50) + 50
        ElseIf A >= 100 And A < 150 Then
            B = 50 / 325 * (A - 150) + 100
        ElseIf A >= 150 And A < 200 Then
            B = 50 / 325 * (A - 475) + 150
        ElseIf A >= 200 And A < 300 Then
            B = 0.2 * (A - 800) + 200
        ElseIf A >= 300 And A < 400 Then
            B = 0.125 * (A - 1600) + 300
        ElseIf A >= 400 And A < 500 Then
            B = 100 / 520 * (A - 2100) + 400
        End If
        TextBox6.Text = B




        If TextBox2.Text.Length = 0 Then
            TextBox2.Text = "0"
        End If


        C = TextBox2.Text
        If C >= 0 And C < 50 Then
            D = 50 / 40 * C
        ElseIf C >= 50 And C < 100 Then
            D = 1.25 * (C - 40) + 50
        ElseIf C >= 100 And C < 150 Then
            D = 0.5 * (C - 80) + 100
        ElseIf C >= 150 And C < 200 Then
            D = 0.5 * (C - 180) + 150
        ElseIf C >= 200 And C < 300 Then
            D = 100 / 285 * (C - 280) + 200
        ElseIf C >= 300 And C < 400 Then
            D = 100 / 185 * (C - 565) + 300
        ElseIf C >= 400 And C < 500 Then
            D = 100 / 190 * (C - 750) + 400
        End If
        TextBox7.Text = D


        If TextBox3.Text.Length = 0 Then
            TextBox3.Text = "0"
        End If

        X1 = TextBox3.Text
        If X1 >= 0 And X1 < 50 Then
            X2 = 1 * X1
        ElseIf X1 >= 50 And X1 < 100 Then
            X2 = 1 * (X1 - 100) + 50
        ElseIf X1 >= 100 And X1 < 150 Then
            X2 = 0.5 * (X1 - 150) + 100
        ElseIf X1 >= 150 And X1 < 200 Then
            X2 = 0.5 * (X1 - 250) + 150
        ElseIf X1 >= 200 And X1 < 300 Then
            X2 = 100 / 70 * (X1 - 350) + 200
        ElseIf X1 >= 300 And X1 < 400 Then
            X2 = 1.25 * (X1 - 420) + 300
        ElseIf X1 >= 400 And X1 < 500 Then
            X2 = 1 * (X1 - 500) + 400
        End If
        TextBox8.Text = X2


        If TextBox4.Text.Length = 0 Then
            TextBox4.Text = "0"
        End If

        G = TextBox4.Text
        If G >= 0 And G < 50 Then
            H = 25 * G
        ElseIf G >= 50 And G < 100 Then
            H = 25 * (G - 2) + 50
        ElseIf G >= 100 And G < 150 Then
            H = 5 * (G - 4) + 100
        ElseIf G >= 150 And G < 200 Then
            H = 5 * (G - 14) + 150
        ElseIf G >= 200 And G < 300 Then
            H = 100 / 12 * (G - 24) + 200
        ElseIf G >= 300 And G < 400 Then
            H = 100 / 12 * (G - 36) + 300
        ElseIf G >= 400 And G < 500 Then
            H = 100 / 12 * (G - 48) + 400
        End If
        TextBox9.Text = H


        If TextBox5.Text.Length = 0 Then
            TextBox5.Text = "0"
        End If

        I = TextBox5.Text
        If I >= 0 And I < 50 Then
            J = 50 / 35 * I
        ElseIf I >= 50 And I < 100 Then
            J = 1.25 * (I - 35) + 50
        ElseIf I >= 100 And I < 150 Then
            J = 1.25 * (I - 75) + 100
        ElseIf I >= 150 And I < 200 Then
            J = 50 / 35 * (I - 115) + 150
        ElseIf I >= 200 And I < 300 Then
            J = 1 * (I - 150) + 200
        ElseIf I >= 300 And I < 400 Then
            J = 1 * (I - 250) + 300
        ElseIf I >= 400 And I < 500 Then
            J = 100 / 150 * (I - 350) + 400
        End If
        TextBox10.Text = J




    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim ARR As Single() = {B, D, X2, H, J}
        Dim MAX As Single, i As Integer
        MAX = ARR(0)

        For i = 0 To 4
            If ARR(i) >= MAX Then
                MAX = ARR(i)

            End If
        Next


        TextBox11.Text = MAX



    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MAX = TextBox11.Text
        If MAX >= 0 And MAX <= 50 Then
            TextBox12.Text = "空气质量级别为一级，空气质量状况属于优。此时，空气质量令人满意，基本无空气污染，各类人群可正常活动。"
        ElseIf MAX >= 50 And MAX <= 100 Then
            TextBox12.Text = "空气质量级别为二级，空气质量状况属于良。此时空气质量可接受，但某些污染物可能对极少数异常敏感人群健康有较弱影响，建议极少数异常敏感人群应减少户外活动。"
        ElseIf MAX >= 100 And MAX <= 150 Then
            TextBox12.Text = "空气质量级别为三级，空气质量状况属于轻度污染。此时，易感人群症状有轻度加剧，健康人群出现刺激症状。建议儿童、老年人及心脏病、呼吸系统疾病患者应减少长时间、高强度的户外锻炼。"
        ElseIf MAX >= 151 And MAX <= 200 Then
            TextBox12.Text = "空气质量级别为四级，空气质量状况属于中度污染。此时，进一步加剧易感人群症状，可能对健康人群心脏、呼吸系统有影响，建议疾病患者避免长时间、高强度的户外锻练，一般人群适量减少户外运动。"
        ElseIf MAX >= 201 And MAX <= 300 Then
            TextBox12.Text = "空气质量级别为五级，空气质量状况属于重度污染。此时，心脏病和肺病患者症状显著加剧，运动耐受力降低，健康人群普遍出现症状，建议儿童、老年人和心脏病、肺病患者应停留在室内，停止户外运动，一般人群减少户外运动。"
        ElseIf MAX >= 300 Then
            TextBox12.Text = "空气质量级别为六级，空气质量状况属于严重污染。此时，健康人群运动耐受力降低，有明显强烈症状，提前出现某些疾病，建议儿童、老年人和病人应当留在室内，避免体力消耗，一般人群应避免户外活动。"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If SO2一小时浓度均值.Checked = True Then

            Dim K As Single, L As Single
            If TextBox13.Text.Length = 0 Then
                TextBox13.Text = "0"
            End If
            K = TextBox13.Text
            If K >= 0 And K < 50 Then
                L = 50 / 150 * K
            ElseIf K >= 50 And K < 100 Then
                L = 50 / 350 * (K - 150) + 50
            ElseIf K >= 100 And K < 150 Then
                L = 50 / 150 * (K - 500) + 100
            ElseIf K >= 150 And K < 200 Then
                L = 50 / 150 * (K - 650) + 150

            End If
            TextBox18.Text = L
        End If
        If NO2一小时浓度均值.Checked = True Then
            Dim M As Single, N As Single
            If TextBox13.Text.Length = 0 Then
                TextBox13.Text = "0"
            End If
            M = TextBox13.Text
            If M >= 0 And M < 50 Then
                N = 0.5 * M
            ElseIf M >= 50 And M < 100 Then
                N = 0.5 * (M - 100) + 50
            ElseIf M >= 100 And M < 150 Then
                N = 0.1 * (M - 200) + 100
            ElseIf M >= 150 And M < 200 Then
                N = 0.1 * (M - 700) + 150
            ElseIf M >= 200 And M < 300 Then
                N = 100 / 1140 * (M - 1200) + 200
            ElseIf M >= 300 And M < 400 Then
                N = 100 / 750 * (M - 2340) + 300
            ElseIf M >= 400 And M < 500 Then
                N = 100 / 750 * (M - 3090) + 400
            End If
            TextBox18.Text = N
        End If
        If CO一小时浓度均值.Checked = True Then
            Dim O As Single, P As Single
            If TextBox13.Text.Length = 0 Then
                TextBox13.Text = "0"
            End If
            O = TextBox13.Text
            If O >= 0 And O < 50 Then
                P = 10 * O
            ElseIf O >= 50 And O < 100 Then
                P = 10 * (O - 5) + 50
            ElseIf O >= 100 And O < 150 Then
                P = 2 * (O - 10) + 100
            ElseIf O >= 150 And O < 200 Then
                P = 2 * (O - 35) + 150
            ElseIf O >= 200 And O < 300 Then
                P = 100 / 30 * (O - 60) + 200
            ElseIf O >= 300 And O < 400 Then
                P = 100 / 30 * (O - 90) + 300
            ElseIf O >= 400 And O < 500 Then
                P = 100 / 30 * (O - 120) + 400
            End If
            TextBox18.Text = P
        End If
        If O3一小时浓度均值.Checked = True Then
            Dim Q As Single, R As Single
            If TextBox13.Text.Length = 0 Then
                TextBox13.Text = "0"
            End If
            Q = TextBox13.Text
            If Q >= 0 And Q < 50 Then
                R = 50 / 160 * Q
            ElseIf Q >= 50 And Q < 100 Then
                R = 1.25 * (Q - 160) + 50
            ElseIf Q >= 100 And Q < 150 Then
                R = 0.5 * (Q - 200) + 100
            ElseIf Q >= 150 And Q < 200 Then
                R = 0.5 * (Q - 300) + 150
            ElseIf Q >= 200 And Q < 300 Then
                R = 0.25 * (Q - 400) + 200
            ElseIf Q >= 300 And Q < 400 Then
                R = 0.5 * (Q - 800) + 300
            ElseIf Q >= 400 And Q < 500 Then
                R = 0.5 * (Q - 1000) + 400
            End If
            TextBox18.Text = R
        End If
        If O3八小时浓度均值.Checked = True Then
            Dim S As Single, T As Single
            If TextBox13.Text.Length = 0 Then
                TextBox13.Text = "0"
            End If
            S = TextBox13.Text
            If S >= 0 And S < 50 Then
                T = 0.5 * S
            ElseIf S >= 50 And S < 100 Then
                T = 50 / 60 * (S - 100) + 50
            ElseIf S >= 100 And S < 150 Then
                T = 50 / 55 * (S - 160) + 100
            ElseIf S >= 150 And S < 200 Then
                T = 1 * (S - 215) + 150
            ElseIf S >= 200 And S < 300 Then
                T = 100 / 535 * (S - 265) + 200

            End If
            TextBox18.Text = T

        End If







    End Sub

   

   
    
End Class



