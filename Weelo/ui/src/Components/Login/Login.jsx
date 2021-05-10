import React,{Fragment,useEffect,useReducer,useContext} from 'react';
import {useHistory} from 'react-router-dom';
import {LogOut} from 'Services/authService';
import Loading from 'Components/Layout/Loading';
import bannerImage from 'assets/img/banner/login.jpg';

const Login = () => {  
  
    return (
      <Fragment>
        
          <div className="container-fluid animated fadeIn">
          <div className="row">
            <div className="col-md-6 d-none d-block p-0"><img className="img-login w-100" src={bannerImage} alt="BannerImage"/></div>
            <div className="col-md-6 d-flex align-items-center justify-content-center">
              <div className="content-login">
                <h5 className="pb-4">Descubre las recompensas</h5>
                <p>Ingresa el código que te hemos enviado. Con él podrás redimir un bono  para ti o podrás donarlo. </p>
                <form className="h-100 " onSubmit={(e)=>e.preventDefault()} id="FormLogin">
                  <div className="group mb-4">
             
                  </div>
                
                 
                
                  <div className="py-3 d-flex justify-content-center align-items-center">
                    <a className="mx-3 button" href="./">Cancelar</a>                    
                    </div>
                </form>
              </div>
            </div>
          </div>
        </div>

    </Fragment>
      );
}
 
export default Login;