# Generated by the gRPC Python protocol compiler plugin. DO NOT EDIT!
"""Client and server classes corresponding to protobuf-defined services."""
import grpc

import virtual_pb2 as virtual__pb2


class data_streamStub(object):
    """Missing associated documentation comment in .proto file."""

    def __init__(self, channel):
        """Constructor.

        Args:
            channel: A grpc.Channel.
        """
        self.stream = channel.unary_unary(
                '/virtual.data_stream/stream',
                request_serializer=virtual__pb2.streamRequest.SerializeToString,
                response_deserializer=virtual__pb2.streamReply.FromString,
                )


class data_streamServicer(object):
    """Missing associated documentation comment in .proto file."""

    def stream(self, request, context):
        """Missing associated documentation comment in .proto file."""
        context.set_code(grpc.StatusCode.UNIMPLEMENTED)
        context.set_details('Method not implemented!')
        raise NotImplementedError('Method not implemented!')


def add_data_streamServicer_to_server(servicer, server):
    rpc_method_handlers = {
            'stream': grpc.unary_unary_rpc_method_handler(
                    servicer.stream,
                    request_deserializer=virtual__pb2.streamRequest.FromString,
                    response_serializer=virtual__pb2.streamReply.SerializeToString,
            ),
    }
    generic_handler = grpc.method_handlers_generic_handler(
            'virtual.data_stream', rpc_method_handlers)
    server.add_generic_rpc_handlers((generic_handler,))


 # This class is part of an EXPERIMENTAL API.
class data_stream(object):
    """Missing associated documentation comment in .proto file."""

    @staticmethod
    def stream(request,
            target,
            options=(),
            channel_credentials=None,
            call_credentials=None,
            insecure=False,
            compression=None,
            wait_for_ready=None,
            timeout=None,
            metadata=None):
        return grpc.experimental.unary_unary(request, target, '/virtual.data_stream/stream',
            virtual__pb2.streamRequest.SerializeToString,
            virtual__pb2.streamReply.FromString,
            options, channel_credentials,
            insecure, call_credentials, compression, wait_for_ready, timeout, metadata)
