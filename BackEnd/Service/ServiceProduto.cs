using AutoMapper;
using BackEnd.DTOs;
using BackEnd.Entities;
using BackEnd.Interfaces;

namespace BackEnd.Service
{
    public class ServiceProduto : IServiceProduto
    {
        public IMapper mapper;

        public IMongoRepository repository;

        public ITokenService tokenService;

        public ServiceProduto(IMapper _mapper, IMongoRepository _mongoRepository)
        {
            mapper = _mapper;
            repository = _mongoRepository;

        }

        public ProdutoEntity AdicionarProdutos(ProdutoDTO produtoDTO)
        {
            ProdutoEntity produtoEntity = new ProdutoEntity();
            mapper.Map(produtoDTO, produtoEntity);
            var produtodatabase = repository.EncontraProduto(produtoEntity);

            if (produtoEntity.Equals(produtodatabase))
            {
                throw new BadHttpRequestException("Já ta no banco esse produto");
            }

            else
            {
                repository.AdicionarProduto(produtoEntity);  
                return produtoEntity;
            }



            }

        public List<ProdutoEntity> ListarProdutos()
        {
            return repository.ListarProdutos(); 
        }




        }
    }
