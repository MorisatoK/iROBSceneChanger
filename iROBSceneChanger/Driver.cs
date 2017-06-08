namespace iROBSceneChanger
{
    /// <summary>
    /// Represents a driver in the current session.
    /// </summary>
    public class Driver
    {
        public Driver()
        {
        }

        /// <summary>
        /// The identifier (CarIdx) of this driver (unique to this session)
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the driver
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The customer ID (custid) of the driver
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Whether or not the driver is currently on the track
        /// </summary>
        public bool IsOnTrack { get; set; }
    }
}
