using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalClassLibrary.Migrations
{
    public partial class ChangeShiftAndAppointmentDates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 23, 8, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 23, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 23, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 23, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 23, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 23, 18, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 24, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 24, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 24, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 24, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 24, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 24, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 24, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 24, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 24, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 24, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 24, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 24, 18, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 24, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 25, 8, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 25, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 25, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 25, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 25, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 25, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 25, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 25, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 25, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 25, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 25, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 25, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 25, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 25, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 25, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 25, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 25, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 23, 19, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 25, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 25, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 25, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 26, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 26, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 26, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 26, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 26, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 26, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 26, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 26, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 26, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 26, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 26, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 5, 26, 18, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 26, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OnCallShift",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 5, 10, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OnCallShift",
                keyColumn: "Id",
                keyValue: 2,
                column: "Start",
                value: new DateTime(2022, 5, 10, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OnCallShift",
                keyColumn: "Id",
                keyValue: 3,
                column: "Start",
                value: new DateTime(2022, 5, 11, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OnCallShift",
                keyColumn: "Id",
                keyValue: 4,
                column: "Start",
                value: new DateTime(2022, 5, 11, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OnCallShift",
                keyColumn: "Id",
                keyValue: 5,
                column: "Start",
                value: new DateTime(2022, 5, 12, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OnCallShift",
                keyColumn: "Id",
                keyValue: 6,
                column: "Start",
                value: new DateTime(2022, 5, 12, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OnCallShift",
                keyColumn: "Id",
                keyValue: 7,
                column: "Start",
                value: new DateTime(2022, 5, 13, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OnCallShift",
                keyColumn: "Id",
                keyValue: 8,
                column: "Start",
                value: new DateTime(2022, 5, 13, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OnCallShift",
                keyColumn: "Id",
                keyValue: 9,
                column: "Start",
                value: new DateTime(2022, 5, 14, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OnCallShift",
                keyColumn: "Id",
                keyValue: 10,
                column: "Start",
                value: new DateTime(2022, 5, 14, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OnCallShift",
                keyColumn: "Id",
                keyValue: 11,
                column: "Start",
                value: new DateTime(2022, 5, 15, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OnCallShift",
                keyColumn: "Id",
                keyValue: 12,
                column: "Start",
                value: new DateTime(2022, 5, 15, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 5, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 5, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 5, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 5, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 12, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 5, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 12, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 5, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 13, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 5, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 13, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 5, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 5, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 15, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 5, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 5, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 5, 29, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 29, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 5, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 29, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 5, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 30, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 5, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 30, 17, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 23, 8, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 23, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 23, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 23, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 23, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 23, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 23, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 23, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 23, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 23, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 23, 18, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 23, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 24, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 24, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 24, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 24, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 24, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 24, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 24, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 24, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 24, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 24, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 24, 18, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 24, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 25, 8, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 25, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 25, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 25, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 25, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 25, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 25, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 25, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 25, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 25, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 25, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 25, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 25, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 25, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 25, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 25, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 25, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 25, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 25, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 23, 19, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 25, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 25, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 25, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 26, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 26, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 26, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 26, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 26, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 26, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 26, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 26, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 26, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 26, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 26, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 11, 26, 18, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 26, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OnCallShift",
                keyColumn: "Id",
                keyValue: 1,
                column: "Start",
                value: new DateTime(2022, 1, 10, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OnCallShift",
                keyColumn: "Id",
                keyValue: 2,
                column: "Start",
                value: new DateTime(2022, 1, 10, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OnCallShift",
                keyColumn: "Id",
                keyValue: 3,
                column: "Start",
                value: new DateTime(2022, 1, 11, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OnCallShift",
                keyColumn: "Id",
                keyValue: 4,
                column: "Start",
                value: new DateTime(2022, 1, 11, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OnCallShift",
                keyColumn: "Id",
                keyValue: 5,
                column: "Start",
                value: new DateTime(2022, 1, 12, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OnCallShift",
                keyColumn: "Id",
                keyValue: 6,
                column: "Start",
                value: new DateTime(2022, 1, 12, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OnCallShift",
                keyColumn: "Id",
                keyValue: 7,
                column: "Start",
                value: new DateTime(2022, 1, 13, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OnCallShift",
                keyColumn: "Id",
                keyValue: 8,
                column: "Start",
                value: new DateTime(2022, 1, 13, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OnCallShift",
                keyColumn: "Id",
                keyValue: 9,
                column: "Start",
                value: new DateTime(2022, 1, 14, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OnCallShift",
                keyColumn: "Id",
                keyValue: 10,
                column: "Start",
                value: new DateTime(2022, 1, 14, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OnCallShift",
                keyColumn: "Id",
                keyValue: 11,
                column: "Start",
                value: new DateTime(2022, 1, 15, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OnCallShift",
                keyColumn: "Id",
                keyValue: 12,
                column: "Start",
                value: new DateTime(2022, 1, 15, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 1, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 10, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 1, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 10, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 1, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 1, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 1, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 12, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 1, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 12, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 1, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 13, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 1, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 13, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 1, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 1, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 15, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 16, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 1, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 17, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 1, 29, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 29, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 1, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 29, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 1, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 30, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 1, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 30, 17, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
