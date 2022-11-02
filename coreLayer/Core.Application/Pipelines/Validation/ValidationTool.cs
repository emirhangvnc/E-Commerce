using Castle.DynamicProxy;
using Core.Application.Pipelines.Validation.FluentValidation;
using Core.Security.Interceptors;
using FluentValidation;

namespace Core.Application.Pipelines.Validation
{
    public class ValidationTool
    {
        public class ValidationAspect : MethodInterception
        {
            private Type _validatorType;
            public ValidationAspect(Type validatorType)
            {
                if (!typeof(IValidator).IsAssignableFrom(validatorType))
                {
                    throw new Exception("Bu Bir Doğrulama Sınıfı Değildir");
                }

                _validatorType = validatorType;
            }
            protected override void OnBefore(IInvocation invocation)
            {
                var validator = (IValidator)Activator.CreateInstance(_validatorType);
                var entityType = _validatorType.BaseType.GetGenericArguments()[0];
                var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
                foreach (var entity in entities)
                {
                    ValidationTools.Validate(validator, entity);
                }
            }
        }
    }
}