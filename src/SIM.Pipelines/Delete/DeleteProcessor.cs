﻿namespace SIM.Pipelines.Delete
{
  using SIM.Pipelines.Processors;
  using Sitecore.Diagnostics.Base;
  using JetBrains.Annotations;

  #region

  #endregion

  public abstract class DeleteProcessor : Processor
  {
    #region Methods

    protected override sealed void Process([NotNull] ProcessorArgs args)
    {
      Assert.ArgumentNotNull(args, nameof(args));

      Process((DeleteArgs)args);
    }

    protected abstract void Process([NotNull] DeleteArgs args);

    #endregion
  }
}