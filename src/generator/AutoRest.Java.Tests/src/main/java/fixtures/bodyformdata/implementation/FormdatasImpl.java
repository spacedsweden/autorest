/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.bodyformdata.implementation;

import retrofit2.Retrofit;
import fixtures.bodyformdata.Formdatas;
import com.google.common.reflect.TypeToken;
import com.microsoft.rest.ServiceCall;
import com.microsoft.rest.ServiceCallback;
import com.microsoft.rest.ServiceResponse;
import com.microsoft.rest.ServiceResponseBuilder;
import com.microsoft.rest.ServiceResponseCallback;
import fixtures.bodyformdata.models.ErrorException;
import java.io.InputStream;
import java.io.IOException;
import okhttp3.MediaType;
import okhttp3.RequestBody;
import okhttp3.ResponseBody;
import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.Headers;
import retrofit2.http.Multipart;
import retrofit2.http.Part;
import retrofit2.http.POST;
import retrofit2.http.PUT;
import retrofit2.http.Streaming;
import retrofit2.Response;

/**
 * An instance of this class provides access to all the operations defined
 * in Formdatas.
 */
public final class FormdatasImpl implements Formdatas {
    /** The Retrofit service to perform REST calls. */
    private FormdatasService service;
    /** The service client containing this operation class. */
    private AutoRestSwaggerBATFormDataServiceImpl client;

    /**
     * Initializes an instance of Formdatas.
     *
     * @param retrofit the Retrofit instance built from a Retrofit Builder.
     * @param client the instance of the service client containing this operation class.
     */
    public FormdatasImpl(Retrofit retrofit, AutoRestSwaggerBATFormDataServiceImpl client) {
        this.service = retrofit.create(FormdatasService.class);
        this.client = client;
    }

    /**
     * The interface defining all the services for Formdatas to be
     * used by Retrofit to perform actually REST calls.
     */
    interface FormdatasService {
        @Multipart
        @POST("formdata/stream/uploadfile")
        @Streaming
        Call<ResponseBody> uploadFile(@Part("fileContent") RequestBody fileContent, @Part("fileName") String fileName);

        @Headers("Content-Type: application/octet-stream")
        @PUT("formdata/stream/uploadfile")
        @Streaming
        Call<ResponseBody> uploadFileViaBody(@Body RequestBody fileContent);

    }

    /**
     * Upload file.
     *
     * @param fileContent File to upload.
     * @param fileName File name to upload. Name has to be spelled exactly as written here.
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @throws IllegalArgumentException exception thrown from invalid parameters
     * @return the InputStream object wrapped in {@link ServiceResponse} if successful.
     */
    public ServiceResponse<InputStream> uploadFile(byte[] fileContent, String fileName) throws ErrorException, IOException, IllegalArgumentException {
        if (fileContent == null) {
            throw new IllegalArgumentException("Parameter fileContent is required and cannot be null.");
        }
        if (fileName == null) {
            throw new IllegalArgumentException("Parameter fileName is required and cannot be null.");
        }
        RequestBody fileContentConverted = RequestBody.create(MediaType.parse("multipart/form-data"), fileContent);
        Call<ResponseBody> call = service.uploadFile(fileContentConverted, fileName);
        return uploadFileDelegate(call.execute());
    }

    /**
     * Upload file.
     *
     * @param fileContent File to upload.
     * @param fileName File name to upload. Name has to be spelled exactly as written here.
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link Call} object
     */
    public ServiceCall<InputStream> uploadFileAsync(byte[] fileContent, String fileName, final ServiceCallback<InputStream> serviceCallback) {
        if (fileContent == null) {
            throw new IllegalArgumentException("Parameter fileContent is required and cannot be null.");
        }
        if (fileName == null) {
            throw new IllegalArgumentException("Parameter fileName is required and cannot be null.");
        }
        RequestBody fileContentConverted = RequestBody.create(MediaType.parse("multipart/form-data"), fileContent);
        Call<ResponseBody> call = service.uploadFile(fileContentConverted, fileName);
        final ServiceCall<InputStream> serviceCall = new ServiceCall<>(call);
        call.enqueue(new ServiceResponseCallback<InputStream>(serviceCall, serviceCallback) {
            @Override
            public void onResponse(Call<ResponseBody> call, Response<ResponseBody> response) {
                try {
                    ServiceResponse<InputStream> clientResponse = uploadFileDelegate(response);
                    if (serviceCallback != null) {
                        serviceCallback.success(clientResponse);
                    }
                    serviceCall.success(clientResponse);
                } catch (ErrorException | IOException exception) {
                    if (serviceCallback != null) {
                        serviceCallback.failure(exception);
                    }
                    serviceCall.failure(exception);
                }
            }
        });
        return serviceCall;
    }

    private ServiceResponse<InputStream> uploadFileDelegate(Response<ResponseBody> response) throws ErrorException, IOException, IllegalArgumentException {
        return new ServiceResponseBuilder<InputStream, ErrorException>(this.client.mapperAdapter())
                .register(200, new TypeToken<InputStream>() { }.getType())
                .registerError(ErrorException.class)
                .build(response);
    }

    /**
     * Upload file.
     *
     * @param fileContent File to upload.
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @throws IllegalArgumentException exception thrown from invalid parameters
     * @return the InputStream object wrapped in {@link ServiceResponse} if successful.
     */
    public ServiceResponse<InputStream> uploadFileViaBody(byte[] fileContent) throws ErrorException, IOException, IllegalArgumentException {
        if (fileContent == null) {
            throw new IllegalArgumentException("Parameter fileContent is required and cannot be null.");
        }
        RequestBody fileContentConverted = RequestBody.create(MediaType.parse("application/octet-stream"), fileContent);
        Call<ResponseBody> call = service.uploadFileViaBody(fileContentConverted);
        return uploadFileViaBodyDelegate(call.execute());
    }

    /**
     * Upload file.
     *
     * @param fileContent File to upload.
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link Call} object
     */
    public ServiceCall<InputStream> uploadFileViaBodyAsync(byte[] fileContent, final ServiceCallback<InputStream> serviceCallback) {
        if (fileContent == null) {
            throw new IllegalArgumentException("Parameter fileContent is required and cannot be null.");
        }
        RequestBody fileContentConverted = RequestBody.create(MediaType.parse("application/octet-stream"), fileContent);
        Call<ResponseBody> call = service.uploadFileViaBody(fileContentConverted);
        final ServiceCall<InputStream> serviceCall = new ServiceCall<>(call);
        call.enqueue(new ServiceResponseCallback<InputStream>(serviceCall, serviceCallback) {
            @Override
            public void onResponse(Call<ResponseBody> call, Response<ResponseBody> response) {
                try {
                    ServiceResponse<InputStream> clientResponse = uploadFileViaBodyDelegate(response);
                    if (serviceCallback != null) {
                        serviceCallback.success(clientResponse);
                    }
                    serviceCall.success(clientResponse);
                } catch (ErrorException | IOException exception) {
                    if (serviceCallback != null) {
                        serviceCallback.failure(exception);
                    }
                    serviceCall.failure(exception);
                }
            }
        });
        return serviceCall;
    }

    private ServiceResponse<InputStream> uploadFileViaBodyDelegate(Response<ResponseBody> response) throws ErrorException, IOException, IllegalArgumentException {
        return new ServiceResponseBuilder<InputStream, ErrorException>(this.client.mapperAdapter())
                .register(200, new TypeToken<InputStream>() { }.getType())
                .registerError(ErrorException.class)
                .build(response);
    }

}
