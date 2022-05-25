using Pinturas.Dtos.Requests;
using Pinturas.Dtos.Responses;
using Pinturas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinturas.Business
{
    public class FakeProductService : IProductService
    {
        private List<Product> products;
        public FakeProductService()
        {
            products = new List<Product>
             {
                 new Product{ Id=1, Name="The Scream", Price=130, Discount=0.10, Descriptipn="Edvard Munch, National Gallery of Norway", CategoryId=2, ImageUrl="https://commons.wikimedia.org/wiki/File:Edvard_Munch_-_The_Scream_-_Google_Art_Project.jpg"},
                 new Product{ Id=2, Name="Jeanne Hébuterne with Hat and Necklace", Price=110, Discount=0.15, Descriptipn="Amedeo Modigliani, Private Collection", CategoryId=2, ImageUrl="https://bayaiyi.com/wp-content/uploads/2020/06/Jeanne-Hebuterne-with-Necklace.jpg"},
                 new Product{ Id=3, Name="The Starry Night", Price=180, Discount=0.10, Descriptipn="Vincent van Gogh, Museum of Modern Art", CategoryId=4, ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg/1024px-Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg"},
                 new Product{ Id=4, Name="Les Joueurs de Cartes", Price=190, Discount=0.05, Descriptipn="Paul Cezanne, Musee d'Orsay", CategoryId=4, ImageUrl="https://upload.wikimedia.org/wikipedia/commons/6/69/Les_Joueurs_de_cartes%2C_par_Paul_C%C3%A9zanne.jpg"},
                 new Product{ Id=5, Name="Guernica", Price=220, Discount=0.10, Descriptipn="Pablo Picasso, Museo Nacional Centro de Arte Reina Sofia", CategoryId=1, ImageUrl="https://upload.wikimedia.org/wikipedia/tr/7/7f/Picasso_Guernica.jpg"},
                 new Product{ Id=6, Name="Portrait of Ramón Gómez de la Serna", Price=105, Discount=0.15, Descriptipn="Diego Rivera, MALBA", CategoryId=1, ImageUrl="https://upload.wikimedia.org/wikipedia/commons/1/11/Ram%C3%B3nG%C3%B3mezdelaSerna.JPG"},
                 new Product{ Id=7, Name="Garden at Sainte-Adresse", Price=160, Discount=0.05, Descriptipn="Claude Monet, Metropolitan Museum of Art", CategoryId=3, ImageUrl="https://upload.wikimedia.org/wikipedia/commons/a/a0/Claude_Monet_-_Jardin_%C3%A0_Sainte-Adresse.jpg"},
                 new Product{ Id=8, Name="The Luncheon on the Grass", Price=150, Discount=0.10, Descriptipn="Edouard Manet, Musee d'Orsay", CategoryId=3, ImageUrl="https://upload.wikimedia.org/wikipedia/commons/9/90/Edouard_Manet_-_Luncheon_on_the_Grass_-_Google_Art_Project.jpg"},
             };
        }

        public Task<int> AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddProduct(AddProductRequest product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductListResponse> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Product> GetProducts()
        {
            return products;
        }

        public Task<bool> IsExist(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateProduct(UpdateProductRequest request)
        {
            throw new NotImplementedException();
        }

        Task<ICollection<ProductListResponse>> IProductService.GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
