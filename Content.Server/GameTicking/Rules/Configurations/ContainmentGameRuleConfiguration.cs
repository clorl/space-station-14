using System.Linq;
using JetBrains.Annotations;

namespace Content.Server.GameTicking.Rules.Configurations;


/// <summary>
/// Configuration for the containment game mode
/// </summary>
[UsedImplicitly]
public sealed class ContainmentGameRuleConfiguration : GameRuleConfiguration
{
    [DataField("id", required: true)]
    private string _id = default!;

    [DataField("anomalyRoles")]
    private ContainmentAnomalyRoleDataDefinition[] _anomalyRoles = default!;

    public override string Id => _id;
    public ContainmentAnomalyRoleDataDefinition[] AnomalyRoles => _anomalyRoles;
}


/// <summary>
/// Holds data about anomaly roles in the containment game mode.
/// </summary>
[DataDefinition]
public struct ContainmentAnomalyRoleDataDefinition
{
    /// <summary>
    /// The corresponding role prototype ID
    /// </summary>
    [DataField("roleId", required: true)] public string Id = default!;
    [DataField("maxCount")] public int MaxCount = 1;

    public ContainmentAnomalyRoleDataDefinition() {}
}
