namespace SIM.Pipelines.InstallModules
{
  using SIM.Pipelines.Agent;
  using Sitecore.Diagnostics.Base;
  using JetBrains.Annotations;

  #region

  #endregion

  [UsedImplicitly]
  public class DeleteAgentPages : InstallModulesProcessor
  {
    #region Methods

    protected override void Process([NotNull] InstallModulesArgs args)
    {
      Assert.ArgumentNotNull(args, nameof(args));

      AgentHelper.DeleteAgentFiles(args.Instance);
    }

    #endregion
  }
}