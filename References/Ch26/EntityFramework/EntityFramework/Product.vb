'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Product
    Public Property ProductID As Integer
    Public Property ProductName As String
    Public Property SupplierID As Nullable(Of Integer)
    Public Property CategoryID As Nullable(Of Integer)
    Public Property QuantityPerUnit As String
    Public Property UnitPrice As Nullable(Of Decimal)
    Public Property UnitsInStock As Nullable(Of Short)
    Public Property UnitsOnOrder As Nullable(Of Short)
    Public Property ReorderLevel As Nullable(Of Short)
    Public Property Discontinued As Boolean

    Public Overridable Property Category As Category

End Class
