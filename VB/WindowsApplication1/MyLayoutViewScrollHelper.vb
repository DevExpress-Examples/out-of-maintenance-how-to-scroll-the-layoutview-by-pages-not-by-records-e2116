Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Layout
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo
Imports DevExpress.XtraGrid.Views.Layout.Events

Namespace WindowsApplication1
	Public Class MyLayoutViewScrollHelper
		Private _SelectedLayoutView As LayoutView
		Public Property SelectedLayoutView() As LayoutView
			Get
				Return _SelectedLayoutView
			End Get
			Set(ByVal value As LayoutView)
				_SelectedLayoutView = value
			End Set
		End Property

		Public Sub New(ByVal view As LayoutView)
			SelectedLayoutView = view
			AddHandler SelectedLayoutView.VisibleRecordIndexChanged, AddressOf SelectedLayoutView_VisibleRecordIndexChanged
		End Sub

		Private Function GetVisibleCardsCount() As Integer
			Dim visibleCardsCount As Integer = (TryCast(SelectedLayoutView.GetViewInfo(), LayoutViewInfo)).VisibleCards.Count
			Return visibleCardsCount
		End Function
		Private Function GetPageByVisibleIndex(ByVal visibleIndex As Integer) As Integer
            Return visibleIndex \ GetVisibleCardsCount()
		End Function

		Private Function IsScrollForward(ByVal e As LayoutViewVisibleRecordIndexChangedEventArgs) As Boolean
			Return GetPageByVisibleIndex(e.VisibleRecordIndex) = GetPageByVisibleIndex(e.PrevVisibleRecordIndex)
		End Function

		Private Function GetFirstCardIndex(ByVal pageIndex As Integer, ByVal isForward As Boolean) As Integer
			Dim delta As Integer
			If isForward Then
				delta = 1
			Else
				delta = 0
			End If
			Return GetVisibleCardsCount() * (pageIndex + delta)
		End Function

		Private locked As Boolean

		Private Sub ScrollPage(ByVal e As LayoutViewVisibleRecordIndexChangedEventArgs)
			SelectedLayoutView.VisibleRecordIndex = e.PrevVisibleRecordIndex
			SelectedLayoutView.VisibleRecordIndex = GetFirstCardIndex(GetPageByVisibleIndex(e.VisibleRecordIndex), IsScrollForward(e))
		End Sub
		Private Sub SelectedLayoutView_VisibleRecordIndexChanged(ByVal sender As Object, ByVal e As LayoutViewVisibleRecordIndexChangedEventArgs)
			If locked Then
				Return
			End If
			locked = True
			ScrollPage(e)
			locked = False
		End Sub
	End Class
End Namespace
