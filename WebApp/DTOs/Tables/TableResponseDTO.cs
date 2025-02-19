﻿namespace WebApp.DTOs.Tables
{
    public class TableResponseDTO
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public int Capacity { get; set; }
        public TableStatus Status { get; set; }
    }

    public enum TableStatus
    {
        Occupied,
        Available,
        Reserved
    }
}
