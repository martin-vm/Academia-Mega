const AuthModule = (function(){
    //Simular usuario
    const userDB = {
        username: "admin" , 
        password: "1234"
    }

    let currentUser = null;
    return {
        login(username , password){
            if( username === userDB.username  && password === userDB.password ){
                currentUser = UserSingleton.getInstance(username);
                console.log(`Usuario Autenticado: ${currentUser.name}`);
            }else{
                console.log(`Contraseña o usuario incorrectos`)
            }
        },
        logout(){
            if( currentUser ){
                console.log(`Cerrando sesión de usuario: ${currentUser.name}`);
                currentUser=null;
                UserSingleton.clearInstance();

            }else{
                console.log("No hay usuario autenticado");
            }
        }
    }

})();