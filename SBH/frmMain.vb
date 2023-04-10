Public Class frmMain
    Public Sub BookingRoom()
        frmBookingRoom.TopLevel = False
        frmBookingRoom.MdiParent = Me
        Me.Panel3.Controls.Add(frmBookingRoom)
        frmBookingRoom.Show()
    End Sub

    Public Sub ManageBooking()
        frmManageBooking.TopLevel = False
        frmManageBooking.MdiParent = Me
        Me.Panel3.Controls.Add(frmManageBooking)
        frmManageBooking.Show()
    End Sub

    Public Sub InputPayment()
        frmInputPayment.TopLevel = False
        frmInputPayment.MdiParent = Me
        Me.Panel3.Controls.Add(frmInputPayment)
        frmInputPayment.Show()
    End Sub

    Public Sub ViewPayment()
        frmViewPayment.TopLevel = False
        frmViewPayment.MdiParent = Me
        Me.Panel3.Controls.Add(frmViewPayment)
        frmViewPayment.Show()
    End Sub

    Public Sub ManageRoomType()
        frmManageRoomType.TopLevel = False
        frmManageRoomType.MdiParent = Me
        Me.Panel3.Controls.Add(frmManageRoomType)
        frmManageRoomType.Show()
    End Sub

    Public Sub ManageRoom()
        frmManageRoom.TopLevel = False
        frmManageRoom.MdiParent = Me
        Me.Panel3.Controls.Add(frmManageRoom)
        frmManageRoom.Show()
    End Sub

    Public Sub ManageRoomFacility()
        frmManageRoomFacility.TopLevel = False
        frmManageRoomFacility.MdiParent = Me
        Me.Panel3.Controls.Add(frmManageRoomFacility)
        frmManageRoomFacility.Show()
    End Sub

    Public Sub ManageRoomRepairment()
        frmManageRoomRepairment.TopLevel = False
        frmManageRoomRepairment.MdiParent = Me
        Me.Panel3.Controls.Add(frmManageRoomRepairment)
        frmManageRoomRepairment.Show()
    End Sub

    Public Sub ManageDailPrice()
        frmManageDailyPrice.TopLevel = False
        frmManageDailyPrice.MdiParent = Me
        Me.Panel3.Controls.Add(frmManageDailyPrice)
        frmManageDailyPrice.Show()
    End Sub

    Public Sub ManageHolidayPrice()
        frmManageHolidayPrice.TopLevel = False
        frmManageHolidayPrice.MdiParent = Me
        Me.Panel3.Controls.Add(frmManageHolidayPrice)
        frmManageHolidayPrice.Show()
    End Sub

    Public Sub ManageEmployee()
        frmManageEmployee.TopLevel = False
        frmManageEmployee.MdiParent = Me
        Me.Panel3.Controls.Add(frmManageEmployee)
        frmManageEmployee.Show()
    End Sub

    Public Sub ManageGuest()
        frmManageGuest.TopLevel = False
        frmManageGuest.MdiParent = Me
        Me.Panel3.Controls.Add(frmManageGuest)
        frmManageGuest.Show()
    End Sub

    Public Sub TransactionReport()
        frmTransactionReport.TopLevel = False
        frmTransactionReport.MdiParent = Me
        Me.Panel3.Controls.Add(frmTransactionReport)
        frmTransactionReport.Show()
    End Sub

    Public Sub RoomAvailibilityReport()
        frmRoomAvailabilityreport.TopLevel = False
        frmRoomAvailabilityreport.MdiParent = Me
        Me.Panel3.Controls.Add(frmRoomAvailabilityreport)
        frmRoomAvailabilityreport.Show()
    End Sub

    Public Sub ChangePassword()
        frmChangePassword.TopLevel = False
        frmChangePassword.MdiParent = Me
        Me.Panel3.Controls.Add(frmChangePassword)
        frmChangePassword.Show()
    End Sub





    ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''





    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel3.AutoScroll = True
        Call BookingRoom()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call BookingRoom()
        frmManageBooking.Close()
        frmInputPayment.Close()
        frmViewPayment.Close()
        frmManageRoomType.Close()
        frmManageRoom.Close()
        frmManageRoomFacility.Close()
        frmManageRoomRepairment.Close()
        frmManageDailyPrice.Close()
        frmManageHolidayPrice.Close()
        frmManageEmployee.Close()
        frmManageGuest.Close()
        frmTransactionReport.Close()
        frmRoomAvailabilityreport.Close()
        frmChangePassword.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call ManageBooking()
        frmBookingRoom.Close()
        frmInputPayment.Close()
        frmViewPayment.Close()
        frmManageRoomType.Close()
        frmManageRoom.Close()
        frmManageRoomFacility.Close()
        frmManageRoomRepairment.Close()
        frmManageDailyPrice.Close()
        frmManageHolidayPrice.Close()
        frmManageEmployee.Close()
        frmManageGuest.Close()
        frmTransactionReport.Close()
        frmRoomAvailabilityreport.Close()
        frmChangePassword.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call ViewPayment()
        frmBookingRoom.Close()
        frmManageBooking.Close()
        frmInputPayment.Close()
        frmManageRoomType.Close()
        frmManageRoom.Close()
        frmManageRoomFacility.Close()
        frmManageRoomRepairment.Close()
        frmManageDailyPrice.Close()
        frmManageHolidayPrice.Close()
        frmManageEmployee.Close()
        frmManageGuest.Close()
        frmTransactionReport.Close()
        frmRoomAvailabilityreport.Close()
        frmChangePassword.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call InputPayment()
        frmBookingRoom.Close()
        frmManageBooking.Close()
        frmViewPayment.Close()
        frmManageRoomType.Close()
        frmManageRoom.Close()
        frmManageRoomFacility.Close()
        frmManageRoomRepairment.Close()
        frmManageDailyPrice.Close()
        frmManageHolidayPrice.Close()
        frmManageEmployee.Close()
        frmManageGuest.Close()
        frmTransactionReport.Close()
        frmRoomAvailabilityreport.Close()
        frmChangePassword.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call ManageRoomType()
        frmBookingRoom.Close()
        frmManageBooking.Close()
        frmInputPayment.Close()
        frmViewPayment.Close()
        frmManageRoom.Close()
        frmManageRoomFacility.Close()
        frmManageRoomRepairment.Close()
        frmManageDailyPrice.Close()
        frmManageHolidayPrice.Close()
        frmManageEmployee.Close()
        frmManageGuest.Close()
        frmTransactionReport.Close()
        frmRoomAvailabilityreport.Close()
        frmChangePassword.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call ManageRoom()
        frmBookingRoom.Close()
        frmManageBooking.Close()
        frmInputPayment.Close()
        frmViewPayment.Close()
        frmManageRoomType.Close()
        frmManageRoomFacility.Close()
        frmManageRoomRepairment.Close()
        frmManageDailyPrice.Close()
        frmManageHolidayPrice.Close()
        frmManageEmployee.Close()
        frmManageGuest.Close()
        frmTransactionReport.Close()
        frmRoomAvailabilityreport.Close()
        frmChangePassword.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call ManageRoomFacility()
        frmBookingRoom.Close()
        frmManageBooking.Close()
        frmInputPayment.Close()
        frmViewPayment.Close()
        frmManageRoomType.Close()
        frmManageRoom.Close()
        frmManageRoomRepairment.Close()
        frmManageDailyPrice.Close()
        frmManageHolidayPrice.Close()
        frmManageEmployee.Close()
        frmManageGuest.Close()
        frmTransactionReport.Close()
        frmRoomAvailabilityreport.Close()
        frmChangePassword.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Call ManageRoomRepairment()
        frmBookingRoom.Close()
        frmManageBooking.Close()
        frmInputPayment.Close()
        frmViewPayment.Close()
        frmManageRoomType.Close()
        frmManageRoom.Close()
        frmManageRoomFacility.Close()
        frmManageDailyPrice.Close()
        frmManageHolidayPrice.Close()
        frmManageEmployee.Close()
        frmManageGuest.Close()
        frmTransactionReport.Close()
        frmRoomAvailabilityreport.Close()
        frmChangePassword.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Call ManageDailPrice()
        frmBookingRoom.Close()
        frmManageBooking.Close()
        frmInputPayment.Close()
        frmViewPayment.Close()
        frmManageRoomType.Close()
        frmManageRoom.Close()
        frmManageRoomFacility.Close()
        frmManageRoomRepairment.Close()
        frmManageHolidayPrice.Close()
        frmManageEmployee.Close()
        frmManageGuest.Close()
        frmTransactionReport.Close()
        frmRoomAvailabilityreport.Close()
        frmChangePassword.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Call ManageHolidayPrice()
        frmBookingRoom.Close()
        frmManageBooking.Close()
        frmInputPayment.Close()
        frmViewPayment.Close()
        frmManageRoomType.Close()
        frmManageRoom.Close()
        frmManageRoomFacility.Close()
        frmManageRoomRepairment.Close()
        frmManageDailyPrice.Close()
        frmManageEmployee.Close()
        frmManageGuest.Close()
        frmTransactionReport.Close()
        frmRoomAvailabilityreport.Close()
        frmChangePassword.Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Call ManageEmployee()
        frmBookingRoom.Close()
        frmManageBooking.Close()
        frmInputPayment.Close()
        frmViewPayment.Close()
        frmManageRoomType.Close()
        frmManageRoom.Close()
        frmManageRoomFacility.Close()
        frmManageRoomRepairment.Close()
        frmManageDailyPrice.Close()
        frmManageHolidayPrice.Close()
        frmManageGuest.Close()
        frmTransactionReport.Close()
        frmRoomAvailabilityreport.Close()
        frmChangePassword.Close()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Call ManageGuest()
        frmBookingRoom.Close()
        frmManageBooking.Close()
        frmInputPayment.Close()
        frmViewPayment.Close()
        frmManageRoomType.Close()
        frmManageRoom.Close()
        frmManageRoomFacility.Close()
        frmManageRoomRepairment.Close()
        frmManageDailyPrice.Close()
        frmManageHolidayPrice.Close()
        frmManageEmployee.Close()
        frmTransactionReport.Close()
        frmRoomAvailabilityreport.Close()
        frmChangePassword.Close()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click, Button19.Click
        Call ChangePassword()
        frmBookingRoom.Close()
        frmManageBooking.Close()
        frmInputPayment.Close()
        frmViewPayment.Close()
        frmManageRoomType.Close()
        frmManageRoom.Close()
        frmManageRoomFacility.Close()
        frmManageRoomRepairment.Close()
        frmManageDailyPrice.Close()
        frmManageHolidayPrice.Close()
        frmManageEmployee.Close()
        frmManageGuest.Close()
        frmTransactionReport.Close()
        frmRoomAvailabilityreport.Close()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Call TransactionReport()
        frmBookingRoom.Close()
        frmManageBooking.Close()
        frmInputPayment.Close()
        frmViewPayment.Close()
        frmManageRoomType.Close()
        frmManageRoom.Close()
        frmManageRoomFacility.Close()
        frmManageRoomRepairment.Close()
        frmManageDailyPrice.Close()
        frmManageHolidayPrice.Close()
        frmManageEmployee.Close()
        frmManageGuest.Close()
        frmRoomAvailabilityreport.Close()
        frmChangePassword.Close()

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Call RoomAvailibilityReport()
        frmBookingRoom.Close()
        frmManageBooking.Close()
        frmInputPayment.Close()
        frmViewPayment.Close()
        frmManageRoomType.Close()
        frmManageRoom.Close()
        frmManageRoomFacility.Close()
        frmManageRoomRepairment.Close()
        frmManageDailyPrice.Close()
        frmManageHolidayPrice.Close()
        frmManageEmployee.Close()
        frmManageGuest.Close()
        frmTransactionReport.Close()
        frmChangePassword.Close()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        End
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        End
    End Sub
End Class