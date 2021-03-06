﻿Imports DWSIM.Drawing.SkiaSharp.GraphicObjects
Imports DWSIM.Interfaces.Enums.GraphicObjects
Imports DWSIM.DrawingTools.Point

Namespace GraphicObjects.Shapes

    Public Class HeatExchangerGraphic

        Inherits ShapeGraphic

#Region "Constructors"

        Public Sub New()
            Me.ObjectType = DWSIM.Interfaces.Enums.GraphicObjects.ObjectType.HeatExchanger
            Me.Description = "Heat Exchanger"
            CreateConnectors(2, 2)
        End Sub

        Public Sub New(ByVal graphicPosition As SKPoint)
            Me.New()
            Me.SetPosition(graphicPosition)
        End Sub

        Public Sub New(ByVal posX As Integer, ByVal posY As Integer)
            Me.New(New SKPoint(posX, posY))
        End Sub

        Public Sub New(ByVal graphicPosition As SKPoint, ByVal graphicSize As SKSize)
            Me.New(graphicPosition)
            Me.SetSize(graphicSize)
        End Sub

        Public Sub New(ByVal posX As Integer, ByVal posY As Integer, ByVal graphicSize As SKSize)
            Me.New(New SKPoint(posX, posY), graphicSize)
        End Sub

        Public Sub New(ByVal posX As Integer, ByVal posY As Integer, ByVal width As Integer, ByVal height As Integer)
            Me.New(New SKPoint(posX, posY), New SKSize(width, height))
        End Sub

#End Region

        Public Overrides Sub CreateConnectors(InCount As Integer, OutCount As Integer)

            'Creates all the connection points.

            If InputConnectors.Count = 0 Then

                For I As Integer = 1 To InCount

                    Dim Con As New ConnectionPoint
                    Con.Type = ConType.ConIn
                    InputConnectors.Add(Con)

                Next

            End If

            If OutputConnectors.Count = 0 Then

                For I As Integer = 1 To OutCount

                    Dim Con As New ConnectionPoint
                    Con.Type = ConType.ConOut
                    OutputConnectors.Add(Con)

                Next

            End If

            With InputConnectors
                .Item(0).Position = New Point(X, Y + 0.5 * Height)
                .Item(1).Position = New Point(X + 0.5 * Width, Y)
                .Item(1).Direction = ConDir.Down
                .Item(0).ConnectorName = "Inlet Stream 1"
                .Item(1).ConnectorName = "Inlet Stream 2"
            End With

            With OutputConnectors
                .Item(0).Position = New Point(X + Width, Y + 0.5 * Height)
                .Item(1).Position = New Point(X + 0.5 * Width, Y + Height)
                .Item(1).Direction = ConDir.Down
                .Item(0).ConnectorName = "Outlet Stream 1"
                .Item(1).ConnectorName = "Outlet Stream 2"
            End With

            Me.EnergyConnector.Active = False

        End Sub

        Public Overrides Sub Draw(ByVal g As Object)

            Dim canvas As SKCanvas = DirectCast(g, SKCanvas)

            CreateConnectors(0, 0)
            UpdateStatus()

            MyBase.Draw(g)


            Dim myPen As New SKPaint()
            With myPen
                .Color = LineColor
                .StrokeWidth = LineWidth
                .IsStroke = Not Fill
                .IsAntialias = GlobalSettings.Settings.DrawingAntiAlias
            End With

            Dim gp As New SKPath()

            gp.MoveTo(Convert.ToInt32(X), Convert.ToInt32(Y + Height))

            gp.LineTo(Convert.ToInt32(X + (2 / 8) * Width), Convert.ToInt32(Y + (3 / 8) * Height))
            gp.LineTo(Convert.ToInt32(X + (6 / 8) * Width), Convert.ToInt32(Y + (5 / 8) * Height))
            gp.LineTo(Convert.ToInt32(X + Width), Convert.ToInt32(Y))

            Dim myrect As New SKRect(X, Y, X + Width, Y + Height)

            If GradientMode Then

                Dim r0 As New SKRect(X, Y, X + Width, Y + Height)

                Dim radius2 = 0.8F * Math.Min(Width, Height)
                Dim center = New SKPoint(r0.MidX, r0.MidY)
                Dim offCenter = center - New SKPoint(radius2 / 2, radius2 / 2)

                Dim gradPen As New SKPaint()
                With gradPen
                    .Color = LineColor
                    .StrokeWidth = LineWidth
                    .IsStroke = False
                    .IsAntialias = GlobalSettings.Settings.DrawingAntiAlias
                    .Shader = SKShader.CreateTwoPointConicalGradient(
                                    offCenter, 1, center, radius2,
                                    New SKColor() {SKColors.White, LineColor},
                                    Nothing, SKShaderTileMode.Clamp)
                End With

                canvas.DrawOval(myrect, gradPen)

            End If

            canvas.DrawOval(myrect, myPen)
            canvas.DrawPath(gp, myPen)


        End Sub

    End Class

End Namespace