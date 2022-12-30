Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography

Module mdlglobal
    Public conn As SqlConnection
    Public DA As SqlDataAdapter
    Public DR As SqlDataReader
    Public cmd As SqlCommand
    Public DS As DataSet
    Public DT As DataTable
    Public simpan, ubah, hapus As String
    Public sq As String
    Public EngineSqlServer As Boolean = True



    Public x, y, z, a, y1 As Double
    Public kecil As Double
    Public besar As Double
    Public hsl As Double
    Public Tot As Double


    Public Sub koneksidb()
        Dim sqlcon As String
        sqlcon = "Data Source=DESKTOP-I6BCGJ2;Initial Catalog=Persediaan;Integrated Security=True"
        conn = New SqlConnection(sqlcon)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Public Sub dgstyle(ByVal datagrid As DataGridView)
        datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        datagrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Aqua
        datagrid.ColumnHeadersDefaultCellStyle.Font = New Font("Times New Roman", 9)

        datagrid.DefaultCellStyle.SelectionBackColor = Color.Orange
        datagrid.DefaultCellStyle.SelectionForeColor = Color.Black
        datagrid.DefaultCellStyle.Font = New Font("Times New Roman", 9)
        datagrid.DefaultCellStyle.ForeColor = Color.Black

        datagrid.BackgroundColor = SystemColors.Control
        datagrid.BorderStyle = BorderStyle.Fixed3D
    End Sub
    Public Sub liststyle(ByVal list As ListBox)
        list.Font = New Font("Times New Roman", 10)
        list.BorderStyle = BorderStyle.Fixed3D
        list.BackColor = SystemColors.ControlLight
    End Sub
    Public Function chgStr(ByVal xstring As String) As String
        xstring = IIf(IsDBNull(xstring), "", xstring)
        If Not EngineSqlServer Then
            xstring = Replace(xstring, "\", "\\")
        End If
        Return Replace(xstring, "'", "''")
    End Function

    Public Function FormatAngkaNol(ByVal text As String, ByVal nol As Boolean) As String
        Dim ret As String = ""

        If Not nol Then
            If Val(text) = 0 Then
                ret = ""
            Else
                ret = String.Format("{0:n2}", Double.Parse(text))
            End If
        Else
            If Val(text) = 0 Then
                ret = "0.00"
            Else
                ret = String.Format("{0:n2}", Double.Parse(text))
            End If
        End If
        Return ret
    End Function

    Public Function Terbilang(ByVal nilai As Long) As String
        Dim bilangan As String() = {"", "Satu", "Dua", "Tiga", "Empat", "Lima", "Enam", "Tujuh", "Delapan", "Sembilan", "sepuluh", "Sebelas"}
        If nilai < 12 Then
            Return " " & bilangan(nilai)
        ElseIf nilai < 20 Then
            Return Terbilang(nilai - 10) & " Belas"
        ElseIf nilai < 100 Then
            Return (Terbilang(CInt((nilai \ 10))) & " Puluh") + Terbilang(nilai Mod 10)
        ElseIf nilai < 200 Then
            Return " Seratus" & Terbilang(nilai - 100)
        ElseIf nilai < 1000 Then
            Return (Terbilang(CInt((nilai \ 100))) & " Ratus") + Terbilang(nilai Mod 100)
        ElseIf nilai < 2000 Then
            Return " Seribu" & Terbilang(nilai - 1000)
        ElseIf nilai < 1000000 Then
            Return (Terbilang(CInt((nilai \ 1000))) & " Ribu") + Terbilang(nilai Mod 1000)
        ElseIf nilai < 1000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000))) & " Juta") + Terbilang(nilai Mod 1000000)
        ElseIf nilai < 1000000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000000))) & " Milyar") + Terbilang(nilai Mod 1000000000)
        ElseIf nilai < 1000000000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000000000))) & " Triliyun") + Terbilang(nilai Mod 1000000000000)
        Else
            Return ""
        End If
    End Function
    Public Function ExecuteQuerySQLServer(ByVal mSQL0 As String, ByVal objC As SqlConnection) As DataTable
        Dim objDtAdapter As New SqlDataAdapter
        Dim objDtTable As New DataTable
        Dim objDtSet As New DataSet

        objDtSet = New DataSet
        objDtAdapter.SelectCommand = New SqlCommand(mSQL0, objC)

        objDtAdapter.Fill(objDtSet)
        objDtTable = objDtSet.Tables(0)
        Return objDtTable
    End Function
    
    Public Function ExecuteQuery(ByVal mSQL0 As String) As DataTable

        'mSQL0 = mSQL0.toLower

        If EngineSqlServer Then
            Return ExecuteQuerySQLServer(mSQL0, conn)
        Else
            Return ExecuteQuerySQLServer(mSQL0, conn)
        End If
    End Function
    Public Function fEncrypt(ByVal toEncrypt As String, ByVal key As String, ByVal useHashing As Boolean) As String
        Dim keyArray As Byte()
        Dim toEncryptArray As Byte() = UTF8Encoding.UTF8.GetBytes(toEncrypt)

        If useHashing = True Then
            Dim hashmd5 As New MD5CryptoServiceProvider()
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key))
        Else
            keyArray = UTF8Encoding.UTF8.GetBytes(key)
        End If

        Dim tdes As New TripleDESCryptoServiceProvider()
        tdes.Key = keyArray
        tdes.Mode = CipherMode.ECB
        tdes.Padding = PaddingMode.PKCS7

        Dim cTransform As ICryptoTransform = tdes.CreateEncryptor()
        Dim resultArray As Byte() = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length)

        Return (Convert.ToBase64String(resultArray, 0, resultArray.Length))
    End Function
    Public Function fDecrypt(ByVal toDecrypt As String, ByVal key As String, ByVal useHashing As Boolean) As String
        Dim xNilReturn As String

        Try
            Dim keyArray As Byte()
            Dim toEncryptArray As Byte() = Convert.FromBase64String(toDecrypt)

            If useHashing = True Then
                Dim hashmd5 As New MD5CryptoServiceProvider()
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key))
            Else
                keyArray = UTF8Encoding.UTF8.GetBytes(key)
            End If

            Dim tdes As New TripleDESCryptoServiceProvider()
            tdes.Key = keyArray
            tdes.Mode = CipherMode.ECB
            tdes.Padding = PaddingMode.PKCS7

            Dim cTransform As ICryptoTransform = tdes.CreateDecryptor()
            Dim resultArray As Byte() = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length)
            xNilReturn = UTF8Encoding.UTF8.GetString(resultArray)


        Catch ex As Exception
            xNilReturn = "mmERROR"

        End Try



        Return xNilReturn
    End Function

    Public Function GetPassword(ByVal nmUser As String, ByVal xPassword As String, ByVal decryptPass As String, ByVal Encrypt As Boolean) As String
        If nmUser <> "ATEP" And nmUser <> "IRFAN" And nmUser <> "ADI" And nmUser <> "ARI" Then
            If Encrypt Then
                GetPassword = fEncrypt(xPassword, "svchost.exe", True)
            Else
                GetPassword = fDecrypt(decryptPass, "svchost.exe", True)
            End If
        Else
            If Encrypt Then
                GetPassword = fEncrypt(xPassword, "user", True)
            Else
                GetPassword = fDecrypt(decryptPass, "user", True)
            End If
        End If
        If GetPassword = "mmERROR" Then
            If Encrypt Then
                GetPassword = fEncrypt(xPassword, "user", True)
            Else
                GetPassword = fDecrypt(decryptPass, "user", True)
            End If
        End If
    End Function
End Module
