import {Login as LoginService} from 'Services/authService';
import {POST} from './apiService';
import {SEGMENT,ERROR,RESET_FORM,CATALOG,LOADING,RESET_CLIENT,CLIENT_INFO,TRY_LOAD,CLIENT_INFO_REFRESH,PRODUCT_DETAIL,CLIENT_ATTRIBUTES,CLIENT_ATTRIBUTES_REFRESH,CATALOG_DONATION} from 'Types';
import {getToken} from 'Services/authService';

export const LoginConsume = async(email,passwd) => {
    // dispatch({type:RESET_CLIENT});
    
    let requestData= {email: email ,password:passwd};
    let dataResult =await POST(process.env.API_URL,process.env.API_URL_BASE,
        process.env.API_ACTION_LOGIN,requestData,null);
        
        if(dataResult.Error){
            if(dataResult.StatusCode===401){                
                return false;
            }
         console.log(dataResult);
          return false;
        }
        console.log(dataResult);
        return true;
}
