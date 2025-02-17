﻿namespace PharmacyCityNetwork.Server.Dto;

public class PharmaGroupGetDto
{
    /// <summary>
    /// Id of pharma group
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Pharma group name
    /// </summary>
    public string PharmaGroupName { get; set; } = string.Empty;
}
