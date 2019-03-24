namespace RailwayTicketOffice.Entity
{
    public abstract class Entity
    {
        public int ID { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var anotherEntity = obj as Entity;
            return (this.ID == anotherEntity.ID);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }
}