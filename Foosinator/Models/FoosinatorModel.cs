using System;

using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Validation;
using Mindscape.LightSpeed.Linq;

namespace Foosinator.Models
{
  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table("Players")]
  public partial class Player : Entity<System.Guid>
  {
    #region Fields
  
    [ValidatePresence]
    [ValidateLength(0, 50)]
    private string _name;
    private System.DateTime _created;
    [ValidateLength(0, 50)]
    private string _slackUserId;
    [ValidateLength(0, 500)]
    private string _profilePicture;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the Name entity attribute.</summary>
    public const string NameField = "Name";
    /// <summary>Identifies the Created entity attribute.</summary>
    public const string CreatedField = "Created";
    /// <summary>Identifies the SlackUserId entity attribute.</summary>
    public const string SlackUserIdField = "SlackUserId";
    /// <summary>Identifies the ProfilePicture entity attribute.</summary>
    public const string ProfilePictureField = "ProfilePicture";


    #endregion
    
    #region Relationships

    [ReverseAssociation("Player1")]
    private readonly EntityCollection<Game> _gamesByPlayer1 = new EntityCollection<Game>();
    [ReverseAssociation("Player2")]
    private readonly EntityCollection<Game> _gamesByPlayer2 = new EntityCollection<Game>();
    [ReverseAssociation("Player3")]
    private readonly EntityCollection<Game> _gamesByPlayer3 = new EntityCollection<Game>();
    [ReverseAssociation("Player4")]
    private readonly EntityCollection<Game> _gamesByPlayer4 = new EntityCollection<Game>();
    [ReverseAssociation("Player")]
    private readonly EntityCollection<Result> _results = new EntityCollection<Result>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<Game> GamesByPlayer1
    {
      get { return Get(_gamesByPlayer1); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<Game> GamesByPlayer2
    {
      get { return Get(_gamesByPlayer2); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<Game> GamesByPlayer3
    {
      get { return Get(_gamesByPlayer3); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<Game> GamesByPlayer4
    {
      get { return Get(_gamesByPlayer4); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<Result> Results
    {
      get { return Get(_results); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public string Name
    {
      get { return Get(ref _name, "Name"); }
      set { Set(ref _name, value, "Name"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public System.DateTime Created
    {
      get { return Get(ref _created, "Created"); }
      set { Set(ref _created, value, "Created"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string SlackUserId
    {
      get { return Get(ref _slackUserId, "SlackUserId"); }
      set { Set(ref _slackUserId, value, "SlackUserId"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string ProfilePicture
    {
      get { return Get(ref _profilePicture, "ProfilePicture"); }
      set { Set(ref _profilePicture, value, "ProfilePicture"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table("Games")]
  public partial class Game : Entity<System.Guid>
  {
    #region Fields
  
    private System.DateTime _created;
    [ValidateLength(0, 50)]
    private string _pin;
    [ValidateLength(0, 50)]
    private string _status;
    [Column("Player1")]
    private System.Guid _player1Id;
    [Column("Player2")]
    private System.Guid _player2Id;
    [Column("Player3")]
    private System.Nullable<System.Guid> _player3Id;
    [Column("Player4")]
    private System.Nullable<System.Guid> _player4Id;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the Created entity attribute.</summary>
    public const string CreatedField = "Created";
    /// <summary>Identifies the Pin entity attribute.</summary>
    public const string PinField = "Pin";
    /// <summary>Identifies the Status entity attribute.</summary>
    public const string StatusField = "Status";
    /// <summary>Identifies the Player1Id entity attribute.</summary>
    public const string Player1IdField = "Player1Id";
    /// <summary>Identifies the Player2Id entity attribute.</summary>
    public const string Player2IdField = "Player2Id";
    /// <summary>Identifies the Player3Id entity attribute.</summary>
    public const string Player3IdField = "Player3Id";
    /// <summary>Identifies the Player4Id entity attribute.</summary>
    public const string Player4IdField = "Player4Id";


    #endregion
    
    #region Relationships

    [ReverseAssociation("Game")]
    private readonly EntityCollection<Result> _results = new EntityCollection<Result>();
    [ReverseAssociation("GamesByPlayer1")]
    private readonly EntityHolder<Player> _player1 = new EntityHolder<Player>();
    [ReverseAssociation("GamesByPlayer2")]
    private readonly EntityHolder<Player> _player2 = new EntityHolder<Player>();
    [ReverseAssociation("GamesByPlayer3")]
    private readonly EntityHolder<Player> _player3 = new EntityHolder<Player>();
    [ReverseAssociation("GamesByPlayer4")]
    private readonly EntityHolder<Player> _player4 = new EntityHolder<Player>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<Result> Results
    {
      get { return Get(_results); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public Player Player1
    {
      get { return Get(_player1); }
      set { Set(_player1, value); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public Player Player2
    {
      get { return Get(_player2); }
      set { Set(_player2, value); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public Player Player3
    {
      get { return Get(_player3); }
      set { Set(_player3, value); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public Player Player4
    {
      get { return Get(_player4); }
      set { Set(_player4, value); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public System.DateTime Created
    {
      get { return Get(ref _created, "Created"); }
      set { Set(ref _created, value, "Created"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string Pin
    {
      get { return Get(ref _pin, "Pin"); }
      set { Set(ref _pin, value, "Pin"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string Status
    {
      get { return Get(ref _status, "Status"); }
      set { Set(ref _status, value, "Status"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="Player1" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Guid Player1Id
    {
      get { return Get(ref _player1Id, "Player1Id"); }
      set { Set(ref _player1Id, value, "Player1Id"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="Player2" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Guid Player2Id
    {
      get { return Get(ref _player2Id, "Player2Id"); }
      set { Set(ref _player2Id, value, "Player2Id"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="Player3" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<System.Guid> Player3Id
    {
      get { return Get(ref _player3Id, "Player3Id"); }
      set { Set(ref _player3Id, value, "Player3Id"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="Player4" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<System.Guid> Player4Id
    {
      get { return Get(ref _player4Id, "Player4Id"); }
      set { Set(ref _player4Id, value, "Player4Id"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table("Results")]
  public partial class Result : Entity<System.Guid>
  {
    #region Fields
  
    private System.DateTime _created;
    [ValidatePresence]
    [ValidateLength(0, 50)]
    private string _status;
    private System.Nullable<System.Guid> _playerId;
    private System.Guid _gameId;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the Created entity attribute.</summary>
    public const string CreatedField = "Created";
    /// <summary>Identifies the Status entity attribute.</summary>
    public const string StatusField = "Status";
    /// <summary>Identifies the PlayerId entity attribute.</summary>
    public const string PlayerIdField = "PlayerId";
    /// <summary>Identifies the GameId entity attribute.</summary>
    public const string GameIdField = "GameId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("Results")]
    private readonly EntityHolder<Player> _player = new EntityHolder<Player>();
    [ReverseAssociation("Results")]
    private readonly EntityHolder<Game> _game = new EntityHolder<Game>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public Player Player
    {
      get { return Get(_player); }
      set { Set(_player, value); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public Game Game
    {
      get { return Get(_game); }
      set { Set(_game, value); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public System.DateTime Created
    {
      get { return Get(ref _created, "Created"); }
      set { Set(ref _created, value, "Created"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string Status
    {
      get { return Get(ref _status, "Status"); }
      set { Set(ref _status, value, "Status"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="Player" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<System.Guid> PlayerId
    {
      get { return Get(ref _playerId, "PlayerId"); }
      set { Set(ref _playerId, value, "PlayerId"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="Game" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Guid GameId
    {
      get { return Get(ref _gameId, "GameId"); }
      set { Set(ref _gameId, value, "GameId"); }
    }

    #endregion
  }




  /// <summary>
  /// Provides a strong-typed unit of work for working with the FoosinatorModel model.
  /// </summary>
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  public partial class FoosinatorModelUnitOfWork : Mindscape.LightSpeed.UnitOfWork
  {

    public System.Linq.IQueryable<Player> Players
    {
      get { return this.Query<Player>(); }
    }
    
    public System.Linq.IQueryable<Game> Games
    {
      get { return this.Query<Game>(); }
    }
    
    public System.Linq.IQueryable<Result> Results
    {
      get { return this.Query<Result>(); }
    }
    
  }

}
