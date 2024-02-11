namespace Escambo.Application.Services.Interface;
public interface IGenericService<TInutModel,TOutputModel>
{
  
    public ICollection<TOutputModel> GetAll();
   
    public TOutputModel Get(int id);
  
    public int Creat(TInutModel TEntity);

    public TOutputModel Update(TOutputModel TEntity);
    public TOutputModel Delete(int id);


}
