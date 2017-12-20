﻿namespace SIM.Tool.Base.Profiles
{
  using System;
  using Sitecore.Diagnostics.Base;
  using JetBrains.Annotations;

  #region

  #endregion

  public class Profile : DataObject, IProfile, ICloneable
  {
    #region Properties

    #region Public properties

    [NotNull]
    public virtual string ConnectionString
    {
      get
      {
        return GetString("ConnectionString") ?? string.Empty;
      }

      set
      {
        Assert.ArgumentNotNull(value, nameof(value));

        SetValue("ConnectionString", value);
      }
    }

    [NotNull]
    public virtual string InstancesFolder
    {
      get
      {
        return GetString("InstancesFolder") ?? string.Empty;
      }

      set
      {
        Assert.ArgumentNotNull(value, nameof(value));

        SetValue("InstancesFolder", value);
      }
    }

    [NotNull]
    public virtual string License
    {
      get
      {
        return GetString("License") ?? string.Empty;
      }

      set
      {
        Assert.ArgumentNotNull(value, nameof(value));

        SetValue("License", value);
      }
    }

    [NotNull]
    public virtual string LocalRepository
    {
      get
      {
        return GetString("LocalRepository") ?? string.Empty;
      }

      set
      {
        Assert.ArgumentNotNull(value, nameof(value));

        SetValue("LocalRepository", value);
      }
    }

    #endregion

    #region Protected methods

    public void Save()
    {
      throw new NotImplementedException("Not required here");
    }

    #endregion

    #endregion

    #region Implemented Interfaces

    #region ICloneable

    public object Clone()
    {
      return new Profile
      {
        ConnectionString = ConnectionString, 
        InstancesFolder = InstancesFolder, 
        License = License, 
        LocalRepository = LocalRepository
      };
    }

    #endregion

    #endregion
  }
}