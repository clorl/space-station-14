using Content.Server.Actions;
using Content.Server.Chat.Managers;
using Content.Server.Disease;
using Content.Server.GameTicking.Rules.Configurations;
using Content.Server.Objectives.Interfaces;
using Content.Server.Popups;
using Content.Server.Preferences.Managers;
using Content.Server.RoundEnd;
using Content.Server.Zombies;
using Content.Shared.CCVar;
using Robust.Server.Player;
using Robust.Shared.Configuration;
using Robust.Shared.Prototypes;
using Robust.Shared.Random;

namespace Content.Server.GameTicking.Rules;

public class ContainmentGameRuleSystem : GameRuleSystem
{
    [Dependency] private readonly IPrototypeManager _prototypeManager = default!;
    [Dependency] private readonly IRobustRandom _random = default!;
    [Dependency] private readonly IConfigurationManager _cfg = default!;
    [Dependency] private readonly IObjectivesManager _objectivesManager = default!;
    [Dependency] private readonly IChatManager _chatManager = default!;
    [Dependency] private readonly GameTicker _gameTicker = default!;

    public override string Prototype => "Containment";

    private

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<RoundStartAttemptEvent>(OnStartAttempt);
        SubscribeLocalEvent<RulePlayerJobsAssignedEvent>(OnPlayersSpawned);
        SubscribeLocalEvent<RoundEndTextAppendEvent>(OnRoundEndText);
    }

    public override void Started(GameRuleConfiguration configuration)
    {
        if (!Enabled) return;
    }

    public override void Ended(GameRuleConfiguration configuration) {}

    private void OnStartAttempt(RoundStartAttemptEvent ev) {}

    private void OnPlayersSpawned(RulePlayerJobsAssignedEvent ev)
    {

    }
    private void OnRoundEndText(RoundEndTextAppendEvent ev) {}
}
