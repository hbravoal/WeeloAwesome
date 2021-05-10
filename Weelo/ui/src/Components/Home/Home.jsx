import {LOADING,PROGRESS,ERROR,RESET_FORM,CHANGE_LOGIN_FORM_EMAIL,CHANGE_LOGIN_FORM_PASSWORD} from 'Types';
import React,{Fragment,useEffect,useReducer,useContext} from 'react';
import {useHistory} from 'react-router-dom';
import HomeFormData from  'Data/HomeFormData';
import LoadingSpinner from 'Components/Layout/LoadingSpinner';
import Loading from 'Components/Layout/Loading';
import {HomeReducer} from 'Reducers/HomeReducer';
import {GetPropertiesConsume} from 'Services/consumeService';
const Login = () => {

  const history = useHistory();

  const [state,dispatch] = useReducer(HomeReducer, HomeFormData);
  useEffect(() => {  
    dispatch({type:PROGRESS,data:70});
    // LogOut();
    dispatch({type:PROGRESS,data:100});
    return () => {
      dispatch({type:PROGRESS,data:0});
    }
  }, [])


    return (
        <Fragment>
        <Loading progress={state.Progress}></Loading>      
        {state.Loading &&  <LoadingSpinner/>}
          <section className="bg-section awards animated fadeIn">
            <div className="container py-5">
              <div className="row justify-content-center">
                <div className="col-md-10 d-flex justify-content-md-center justify-content-around flex-wrap">
                  <div className="text-left text-md-center w-100">
                    <h5 className="pb-4">¡Gracias por aprender junto a nosotros!</h5>
                    <p>Selecciona el bono que deseas redimir.</p>
                  </div>
                </div>
              </div>
              <div className="row justify-content-center">
                <div className="col-md-10 text-center">

                {/* {Loading && <LoadingSpinner/>}
                        
                        {!Loading && CatalogDonation.map((item,index)=>{
                          return (
                            <Card className="low fadeIn" item={item} key={item.ProductGuid}/>
                          )
                        })
                        }     */}
                </div>
              </div>
            </div>
          </section>
      </Fragment>
      );
}
 
export default Login;