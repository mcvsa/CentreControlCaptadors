Public Class ConfigCycle

    Private Sub BtConfigAndClose_Click(sender As Object, e As EventArgs) Handles BtConfigAndClose.Click
        Dim filterDuration As Integer = NumUDHoresFiltre.Value
        ConfigAlerts.ConfigureAutoAlarm(filterDuration)
        Me.Close()

    End Sub

    Private Sub BtResetAutoAlarm_Click(sender As Object, e As EventArgs) Handles BtResetAutoAlarm.Click
        'If filterDuration is 0, autoalarm will be deactivated
        Dim filterDuration As Integer = 0
        ConfigAlerts.ConfigureAutoAlarm(filterDuration)
        Me.Close()

    End Sub

End Class