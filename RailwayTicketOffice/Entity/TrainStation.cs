using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.ComTypes;

namespace RailwayTicketOffice.Entity
{
    [Table("station")]
    public class TrainStation : Entity
    {
        [Required] public string Name { get; set; }

        public TrainStation(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public TrainStation()
        {
        }
    }
}