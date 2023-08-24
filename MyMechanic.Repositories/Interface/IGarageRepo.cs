using MyMechanic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMechanic.Repositories.Interface
{
    public interface IGarageRepo
    {
        public List<GarageModel> GetGarageDetails(long MechanicId);

        public void AddEditGarage(NewGarageModel data);

        public void UploadGaragePhotos(NewGaragePhotosModel model);

        public List<GaragePhotosModel> GetGaragePhotos(long GarageId, long UserId);

        public string DeleteGaragePhoto(long GarageId, long GaragePhotoId);

    }
}
