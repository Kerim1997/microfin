import axios from "axios";
export default class PostService{
    static async getall(){
        try{
            const response = await axios.get( 'https://localhost:7226/api/Data');
            
            return response.data;
        } catch (e) {
            console.log(e);
            console.log("FUCK");
        }
       
    }
}