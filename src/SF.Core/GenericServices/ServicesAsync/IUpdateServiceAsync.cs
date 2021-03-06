﻿/*******************************************************************************
* �����ռ�: SF.Core.GenericServices.Base
*
* �� �ܣ� N/A
* �� ���� ICreateService
*
* Ver ������� ������ �������
* ����������������������������������������������������������������������
* V0.01 2016/12/8 17:25:54 ������� ����
*
* Copyright (c) 2016 SimpleFramework ��Ȩ����
* Description: SimpleFramework���ٿ���ƽ̨
* Website��http://www.mayisite.com
*********************************************************************************/
using System.Threading.Tasks;

namespace SF.Core.GenericServices.ServicesAsync
{
    public interface IUpdateServiceAsync
    {
        /// <summary>
        /// This updates the data in the database using the input data
        /// </summary>
        /// <typeparam name="T">The type of input data. 
        /// Type must be a type either an EF data class or one of the EfGenericDto's</typeparam>
        /// <param name="data">data to update the class. If Dto then copied over to data class</param>
        /// <returns></returns>
        Task<ISuccessOrErrors> UpdateAsync<T>(T data) where T : class;

        /// <summary>
        /// This is available to reset any secondary data in the dto. Call this if the ModelState was invalid and
        /// you need to display the view again with errors
        /// </summary>
        /// <param name="dto">Must be a dto inherited from EfGenericDtoAsync</param>
        /// <returns></returns>
        Task<T> ResetDtoAsync<T>(T dto) where T : class;
    }
}