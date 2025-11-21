namespace Domain.Interfaces
{
    public interface IDownloadable
    {
        void Download();
    }

    public interface IPlayable
    {
        void Play();
    }

    public interface IRatable
    {
        void Rate(int rating);
    }
}
