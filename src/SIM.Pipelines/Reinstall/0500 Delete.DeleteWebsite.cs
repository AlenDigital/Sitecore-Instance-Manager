﻿namespace SIM.Pipelines.Reinstall
{
  using SIM.Adapters.WebServer;
  using Sitecore.Diagnostics.Base;
  using JetBrains.Annotations;

  #region

  #endregion

  [UsedImplicitly]
  public class DeleteWebsite : ReinstallProcessor
  {
    #region Methods

    protected override void Process([NotNull] ReinstallArgs args)
    {
      Assert.ArgumentNotNull(args, nameof(args));

      WebServerManager.DeleteWebsite(args.WebsiteID);
    }

    #endregion
  }
}