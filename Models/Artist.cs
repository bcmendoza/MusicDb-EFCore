using System;
using System.Collections.Generic;

namespace MusicDb.Models {

  public class Artist : BaseEntity {
    public string Name { get; set; }
    public string Url { get; set; }
    public string Image { get; set; }
    public string Instagram { get; set; }
    public string Twitter { get; set; }
    public List<ArtistLike> Likes { get; set; }

    public Artist() {
      Likes = new List<ArtistLike>();
    }

  }

}