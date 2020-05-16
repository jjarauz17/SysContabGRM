Imports DAL
Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public MustInherit Class ClConexion

    Dim vconsql As New SqlConnection
    Dim vtran As SqlTransaction
    Dim VUsaTransaccion As Boolean

    Protected Function BeginTranSql() As SqlTransaction
        OpenSqlBD()
        If VUsaTransaccion = False Then
            vtran = vconsql.BeginTransaction(Data.IsolationLevel.ReadUncommitted)
            VUsaTransaccion = True
        End If
        Return vtran
    End Function
    Protected ReadOnly Property TransaccionSql() As SqlTransaction
        Get
            Return vtran
        End Get
    End Property
    Protected ReadOnly Property ConeccionSql() As SqlConnection
        Get
            Return vconsql
        End Get
    End Property
    Public Sub New()
        vconsql.ConnectionString = Conexion()
    End Sub
    Protected Sub OpenSqlBD()
        If vconsql.State = Data.ConnectionState.Closed Then
            vconsql.Open()
        End If
    End Sub

    Protected Sub CloseSqlBD()
        If vconsql.State = Data.ConnectionState.Open Then
            vconsql.Close()
        End If
    End Sub
    Protected Sub Commit()
        If VUsaTransaccion Then
            vtran.Commit()
            VUsaTransaccion = False
        End If
    End Sub
    Protected Sub Rollback()
        If VUsaTransaccion Then
            vtran.Rollback()
            VUsaTransaccion = False
        End If
    End Sub

End Class


